using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Frank.Libraries.CodeGeneration.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelcase(this string source)
        {
            var firstCharacter = source.First().ToString().ToLower();

            source = source.Remove(0, 1);
            source = firstCharacter + source;

            return source;
        }


        public static string Remove(this string source, string value) => source.Replace(value, "");

        public static string FallbackIfEmpty(this string source, string value)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return value;
            }

            return source;
        }

        public static string ToSentenceCase(this string source) => Regex.Replace(source, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
        public static string ToTitleCase(this string source)
        {
            var sentenceCase = source.ToSentenceCase();
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(sentenceCase);
        }
    }
}