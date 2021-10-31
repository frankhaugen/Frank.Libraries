using System;
using System.Collections.Generic;

namespace Frank.Libraries.ML.LanguageDetection
{
    public class DetectionEngine
    {
        private readonly LanguageDetectionOptions _options;
        private readonly TextNormalizer _normalizer;
        private readonly ProbabilityEngine _probabilityEngine;
        private readonly WordProbabilities _wordProbabilities;

        public DetectionEngine(LanguageDetectionOptions options, WordProbabilities wordProbabilities)
        {
            _options = options;
            _wordProbabilities = wordProbabilities;
            _normalizer = new TextNormalizer(_options);
            _probabilityEngine = new ProbabilityEngine(_options, _wordProbabilities);
        }

        public IEnumerable<Language> DetectAll(string text)
        {
            var normalizedText = _normalizer.NormalizeText(text);
            var ngrams = _wordProbabilities.ExtractNGrams(normalizedText);
            if (ngrams.Count == 0)
                return Array.Empty<Language>();

            var languageProbabilities = new double[Languages.List.Count];

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