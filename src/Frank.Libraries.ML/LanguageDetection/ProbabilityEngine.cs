using System.Collections.Generic;
using System.Linq;

namespace Frank.Libraries.ML.LanguageDetection;

internal class ProbabilityEngine
{
    private readonly LanguageDetectionOptions _options;
    private readonly WordProbabilities _wordLanguageProbabilities;

    internal ProbabilityEngine(LanguageDetectionOptions options, WordProbabilities wordLanguageProbabilities)
    {
        _options = options;
        _wordLanguageProbabilities = wordLanguageProbabilities;
    }

    internal double[] InitializeProbabilities()
    {
        var prob = new double[Languages.List.Count];
        for (var i = 0; i < prob.Length; i++)
        {
            prob[i] = 1.0 / Languages.List.Count;
        }

        return prob;
    }

    internal void UpdateProbabilities(double[] prob, string word, double alpha)
    {
        if (!_wordLanguageProbabilities.ContainsKey(word))
        {
            return;
        }

        var languageProbabilities = _wordLanguageProbabilities[word];
        var weight = alpha / _options.BaseFrequency!.Value;

        for (var i = 0; i < prob.Length; i++)
        {
            var profile = Languages.List.ElementAt(i);
            prob[i] *= weight
                       + (languageProbabilities.ContainsKey(profile)
                           ? languageProbabilities[profile]
                           : 0);
        }
    }

    internal double NormalizeProbabilities(double[] probs)
    {
        double maxp = 0, sump = 0;

        sump += probs.Sum();

        for (var i = 0; i < probs.Length; ++i)
        {
            var p = probs[i] / sump;
            if (maxp < p)
            {
                maxp = p;
            }

            probs[i] = p;
        }

        return maxp;
    }

    internal IEnumerable<Language> SortProbabilities(double[] probs)
    {
        var list = new List<Language>();

        for (var j = 0; j < probs.Length; j++)
        {
            var p = probs[j];

            if (!(p > _options.ProbabilityThreshold))
            {
                continue;
            }

            for (var i = 0; i <= list.Count; i++)
            {
                if (i != list.Count
                    && !(list[i]
                             .Probability
                         < p))
                {
                    continue;
                }

                list.Insert(i, new Language
                {
                    LanguageCode = Languages.List.ElementAt(j)
                                            .LanguageCode,
                    Probability = p
                });
                break;
            }
        }

        return list;
    }
}