using System.Collections.Generic;

namespace Frank.Libraries.ML.LanguageDetection
{
    public class WordProbabilities : Dictionary<string, Dictionary<LanguageModel, double>> { }
}