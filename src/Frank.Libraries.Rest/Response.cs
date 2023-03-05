using System.Collections.Generic;
using System.Net;

namespace Frank.Libraries.Rest;

public class Response : IResponse
{
    public HttpStatusCode StatusCode { get; init; }
    public string? Content { get; init; }
    public string ReasonPhrase { get; init; }
    public IReadOnlyDictionary<string, string> Headers { get; init; }
    public bool IsSuccessStatusCode { get; init; }
}