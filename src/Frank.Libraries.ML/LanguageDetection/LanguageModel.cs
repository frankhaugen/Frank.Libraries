using System.Collections.Generic;
using Frank.Libraries.Enums.Countries;

namespace Frank.Libraries.ML.LanguageDetection
{
    public class LanguageModel
    {
        public LanguageCode LanguageCode { get; set; }
        public Dictionary<string, int> Frequency { get; set; }
        public int[] WordCount { get; set; }
    }
}
