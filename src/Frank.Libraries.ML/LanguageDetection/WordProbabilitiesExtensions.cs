namespace Frank.Libraries.ML.LanguageDetection;

internal static class WordProbabilitiesExtensions
{
    public static void AddLanguages(this WordProbabilities probabilities, int ngramLength = 3) => probabilities.AddLanguages(Languages.List, ngramLength);

    public static void AddLanguages(this WordProbabilities probabilities, IEnumerable<LanguageModel> profiles, int ngramLength = 3)
    {
        foreach (var languageModel in profiles)
            probabilities.AddLanguage(languageModel, ngramLength);
    }

    internal static void AddLanguage(this WordProbabilities probabilities, LanguageModel profile, int ngramLength = 3)
    {
        foreach (var word in profile.Frequency.Keys)
        {
            if (!probabilities.ContainsKey(word)) probabilities[word] = new Dictionary<LanguageModel, double>();
            if (word.Length < 1 || !(word.Length <= ngramLength)) continue;

            var prob = (double)profile.Frequency[word] / profile.WordCount[word.Length - 1];

            try
            {
                probabilities[word][profile] = prob;
            }
            catch
            {
                // Suppress
            }
        }
    }

    internal static List<string> ExtractNGrams(this WordProbabilities probabilities, string text)
    {
        var list = new List<string>();
        var ngram = new NGram();

        foreach (var c in text)
        {
            ngram.Add(c);
            list.AddRange(ExtractValidNGrams(ngram, probabilities));
        }

        return list;
    }

    private static IEnumerable<string> ExtractValidNGrams(NGram ngram, WordProbabilities probabilities)
    {
        for (var n = 1; n <= NGram.NGramLength; n++)
        {
            var w = ngram.Get(n);
            if (w == null || !probabilities.ContainsKey(w)) continue;
            yield return w;
        }
    }
}