using Frank.Libraries.Enums.Countries;
using Frank.Libraries.Enums.Extensions;

namespace Frank.Libraries.AI.LanguageDetection
{
    public class Language
    {
        public LanguageCode LanguageCode { get; set; }
        public double Probability { get; set; }
        public string Name => LanguageCode.GetName();
    }
}
