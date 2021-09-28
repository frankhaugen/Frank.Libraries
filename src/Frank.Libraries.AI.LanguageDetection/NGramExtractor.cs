using System.Collections.Generic;

namespace Frank.Libraries.AI.LanguageDetection
{
    internal class NGramExtractor
    {
        private readonly Dictionary<string, Dictionary<LanguageModel, double>> _wordLanguageProbabilities;

        internal NGramExtractor(Dictionary<string, Dictionary<LanguageModel, double>> wordLanguageProbabilities)
        {
            _wordLanguageProbabilities = wordLanguageProbabilities;
        }

        internal List<string> Extract(string text)
        {
            var list = new List<string>();

            var ngram = new NGram();

            foreach (var c in text)
            {
                ngram.Add(c);

                for (var n = 1; n <= NGram.NGramLength; n++)
                {
                    var w = ngram.Get(n);

                    if (w != null)
                    {
                        if (!_wordLanguageProbabilities.ContainsKey(w))
                        {
                            continue;
                        }

                        list.Add(w);
                    }
                }
            }

            return list;
        }
    }
}
