using System;
using System.Collections.Generic;
using System.Linq;
using Frank.Libraries.Enums.Countries;

namespace Frank.Libraries.AI.LanguageDetection
{
    public class LanguageDetectionService
    {
        private readonly LanguageDetectionOptions _options;

        private readonly IReadOnlyList<LanguageModel> _languages;
        private readonly Dictionary<string, Dictionary<LanguageModel, double>> _wordLanguageProbabilities;

        private readonly NGramExtractor _nGramExtractor;
        private readonly TextNormalizer _normalizer;
        private readonly ProbabilityEngine _probabilityEngine;

        public LanguageDetectionService(LanguageDetectionOptions options)
        {
            _options = options;

            _languages = new LanguageModels().List;
            _wordLanguageProbabilities = new Dictionary<string, Dictionary<LanguageModel, double>>();
            AddAllLanguages();

            _nGramExtractor = new NGramExtractor(_wordLanguageProbabilities);
            _normalizer = new TextNormalizer(_options);
            _probabilityEngine = new ProbabilityEngine(_options, _languages, _wordLanguageProbabilities);
        }

        private void AddAllLanguages()
        {
            foreach (var language in _languages)
            {
                AddLanguage(language);
            }
        }

        private void AddLanguage(LanguageModel profile)
        {
            foreach (var word in profile.Frequency.Keys)
            {
                if (!_wordLanguageProbabilities.ContainsKey(word))
                    _wordLanguageProbabilities[word] = new Dictionary<LanguageModel, double>();

                if (word.Length >= 1 && word.Length <= _options.NGramLength)
                {
                    var prob = (double)profile.Frequency[word] / profile.WordCount[word.Length - 1];
                    try
                    {
                        _wordLanguageProbabilities[word][profile] = prob;
                    }
                    catch
                    {
                        // Suppress
                    }
                }
            }
        }

        /// <summary>
        /// Checks to see if the provided language is the one provided
        /// </summary>
        /// <param name="languageCode">The three letter ISO language code</param>
        /// <param name="text">The <paramref name="text"/> to be analyzed</param>
        /// <returns>True, false or null</returns>
        public bool? Is(LanguageCode languageCode, string text)
        {
            var detectedLanguages = DetectAll(text);
            var detectedLanguage = detectedLanguages.FirstOrDefault();

            if (detectedLanguage == null)
                return false;

            if (detectedLanguage.LanguageCode == languageCode)
                return true;

            return null;
        }

        public Language? Detect(string text)
        {
            var detectedLanguages = DetectAll(text);
            var detectedLanguage = detectedLanguages.FirstOrDefault();
            return detectedLanguage;
        }

        public IEnumerable<Language> DetectAll(string text)
        {
            var normalizedText = _normalizer.NormalizeText(text);
            var ngrams = _nGramExtractor.Extract(normalizedText);
            if (ngrams.Count == 0)
                return Array.Empty<Language>();

            var languageProbabilities = new double[_languages.LongCount()];

            var random = _options.RandomSeed != null ? new Random(_options.RandomSeed.Value) : new Random();

            for (var t = 0; t < _options.Trials; t++)
            {
                var probs = _probabilityEngine.InitializeProbabilities();
                var alpha = _options.Alpha + random.NextDouble() * _options.AlphaWidth;

                for (var i = 0; ; i++)
                {
                    var r = random.Next(ngrams.Count);
                    _probabilityEngine.UpdateProbabilities(probs, ngrams[r], _options.Alpha!.Value);

                    if (i % 5 == 0)
                    {
                        if (_probabilityEngine.NormalizeProbabilities(probs) > _options.ConvergenceThreshold || i >= _options.MaxIterations)
                            break;
                    }
                }

                for (var j = 0; j < languageProbabilities.Length; j++)
                    languageProbabilities[j] += probs[j] / _options.Trials.Value;
            }

            return _probabilityEngine.SortProbabilities(languageProbabilities);
        }

    }
}
