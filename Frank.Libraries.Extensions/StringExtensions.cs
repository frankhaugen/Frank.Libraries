using System.Globalization;
using System.Text.RegularExpressions;

namespace Frank.Libraries.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmail(this string email) => Regex.IsMatch(email, "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$");

        public static string ToSentenceCase(this string source) => Regex.Replace(source, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");

        public static string ToTitleCase(this string source)
        {
            var sentenceCase = source.ToSentenceCase();
            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(sentenceCase);
        }
    }
}