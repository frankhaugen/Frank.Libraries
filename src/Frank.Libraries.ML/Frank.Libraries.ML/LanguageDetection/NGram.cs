namespace Frank.Libraries.ML.LanguageDetection;

public class NGram
{
    public const int NGramLength = 3;

    private readonly StringBuilder _buffer = new(" ", NGramLength);
    private bool _capital;

    public void Add(char c)
    {
        if (_buffer[^1] == ' ')
        {
            _buffer.Clear()
                   .Append(' ');
            _capital = false;
            if (c != ' ') _buffer.Append(c);
        }
        else
        {
            if (_buffer.Length >= NGramLength) _buffer.Remove(0, 1);
            _buffer.Append(c);
            _capital = char.IsUpper(c) && char.IsUpper(_buffer[^2]);
        }
    }

    public string? Get(int n) => !IsValidNGram(n) ? null : n != 1 ? _buffer.ToString(_buffer.Length - n, n) : GetCharacterAsNullableString();

    private bool IsValidNGram(int n) => !_capital && n is >= 1 and <= NGramLength && _buffer.Length >= n;

    private string? GetCharacterAsNullableString() => _buffer[^1] == ' '
        ? null
        : _buffer[^1]
            .ToString();
}