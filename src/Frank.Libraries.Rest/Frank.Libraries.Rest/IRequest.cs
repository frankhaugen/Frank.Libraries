namespace Frank.Libraries.Rest;

public interface IRequest
{
    string? Content { get; }
    Headers Headers { get; }
    Method Method { get; }
    IUrl Url { get; }
}