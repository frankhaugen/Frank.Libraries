using System.Text;

namespace Frank.Libraries.AI.LanguageDetection
{
    internal class NGram
    {
        public const int N_GRAM = 3;

        private StringBuilder buffer = new StringBuilder(" ", N_GRAM);
        private bool capital = false;

        public void Add(char c)
        {
            var lastChar = buffer[^1];

            if (lastChar == ' ')
            {
                buffer = new StringBuilder(" ");
                capital = false;
                if (c == ' ') return;
            }
            else if (buffer.Length >= N_GRAM)
            {
                buffer.Remove(0, 1);
            }

            buffer.Append(c);

            if (char.IsUpper(c))
            {
                if (char.IsUpper(lastChar))
                    capital = true;
            }
            else
            {
                capital = false;
            }
        }

        public string? Get(int n)
        {
            if (capital)
                return null;

            if (n < 1)
                return null;
            if (n > N_GRAM || buffer.Length < n)
                return null;

            if (n != 1)
                return buffer.ToString(buffer.Length - n, n);

            var c = buffer[^1];
            return c == ' ' ? null : c.ToString();
        }
    }
}
