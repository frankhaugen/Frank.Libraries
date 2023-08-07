namespace Frank.Libraries.Rest;

public class Request : IRequest
{
    public Headers Headers { get; } = new();
    public string? Content { get; set; }
    public Method Method { get; init; }
    public IUrl Url { get; init; }
}