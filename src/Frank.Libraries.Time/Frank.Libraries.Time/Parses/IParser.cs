namespace Frank.Libraries.Time.Parses;

public interface IParser<T>
{
    string ParseMessage { get; set; }
    bool TryParse(string value, out T result);
}