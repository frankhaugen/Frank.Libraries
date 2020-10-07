using System.Collections.Generic;

namespace Frank.Libraries.AI.LanguageDetection
{
    public class Language
    {
        public string Code { get; set; }
        public Dictionary<string, int> Frequencies { get; set; }
        public int[] WordCount { get; set; }
    }
}
