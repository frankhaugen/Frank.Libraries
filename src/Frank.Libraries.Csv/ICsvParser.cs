namespace Frank.Libraries.Csv;

public interface ICsvParser
{
    ICsvDocument Parse(string name, ReadOnlySpan<char> data);
}