using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Frank.Libraries.AI.LanguageDetection
{
    internal class TextNormalizer
    {
        private readonly Regex _urlRegex = new Regex("https?://[-_.?&~;+=/#0-9A-Za-z]{1,2076}", RegexOptions.Compiled);
        private readonly Regex _emailRegex = new Regex("[-_.0-9A-Za-z]{1,64}@[-_0-9A-Za-z]{1,255}[-_.0-9A-Za-z]{1,255}", RegexOptions.Compiled);
        private readonly LanguageDetectionOptions _options;

        public TextNormalizer(LanguageDetectionOptions options)
        {
            _options = options;
        }

        internal string NormalizeText(string text)
        {
            if (text.Length > _options.MaxTextLength)
                text = text.Substring(0, _options.MaxTextLength.Value);

            text = RemoveAddresses(text);
            text = NormalizeAlphabet(text);
            text = NormalizeWhitespace(text);

            return text;
        }

        internal string NormalizeAlphabet(string text)
        {
            var latinCount = 0;
            var nonLatinCount = 0;

            foreach (var c in text)
            {
                if (c <= 'z' && c >= 'A')
                    ++latinCount;
                else if (c >= '\u0300' && !(c >= 0x1e00 && c <= 0x1eff))
                    ++nonLatinCount;
            }

            if (latinCount * 2 >= nonLatinCount)
                return text;

            var textWithoutLatin = new StringBuilder();
            foreach (var c in text.Where(c => c > 'z' || c < 'A'))
            {
                textWithoutLatin.Append(c);
            }
            text = textWithoutLatin.ToString();

            return text;
        }

        internal string NormalizeWhitespace(string text)
        {
            var sb = new StringBuilder(text.Length);

            char? prev = null;

            foreach (var c in text)
            {
                if (c != ' ' || prev != ' ')
                    sb.Append(c);
                prev = c;
            }

            return sb.ToString();
        }

        internal string RemoveAddresses(string text)
        {
            text = _urlRegex.Replace(text, " ");
            text = _emailRegex.Replace(text, " ");
            return text;
        }
    }
}
