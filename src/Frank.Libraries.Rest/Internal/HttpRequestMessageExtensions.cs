using System.Net.Http;

namespace Frank.Libraries.Rest.Internal;

public static class HttpRequestMessageExtensions
{
    public static void AddHeaders(this HttpRequestMessage httpRequestMessage, Headers headers)
    {
        foreach (var header in headers.ToDictionary())
        {
            httpRequestMessage.Headers.Add(header.Key, header.Value);
        }
    }
}