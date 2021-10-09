using System.Text;

namespace Frank.Libraries.ML.LanguageDetection
{
    internal class NGram
    {
        public const int NGramLength = 3;

        private StringBuilder _buffer = new StringBuilder(" ", NGramLength);
        private bool _capital = false;

        public void Add(char c)
        {
            var lastChar = _buffer[^1];

            if (lastChar == ' ')
            {
                _buffer = new StringBuilder(" ");
                _capital = false;
                if (c == ' ') return;
            }
            else if (_buffer.Length >= NGramLength)
            {
                _buffer.Remove(0, 1);
            }

            _buffer.Append(c);

            if (char.IsUpper(c))
            {
                if (char.IsUpper(lastChar))
                    _capital = true;
            }
            else
            {
                _capital = false;
            }
        }

        public string? Get(int n)
        {
            if (_capital)
                return null;

            if (n < 1)
                return null;
            if (n > NGramLength || _buffer.Length < n)
                return null;

            if (n != 1)
                return _buffer.ToString(_buffer.Length - n, n);

            var c = _buffer[^1];
            return c == ' ' ? null : c.ToString();
        }
    }
}
