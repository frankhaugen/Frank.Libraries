using System;

namespace Frank.Libraries.Rest;

public class RequestOptions
{
    public Uri Endpoint { get; init; }
    public Method Method { get; init; }
}