using System.Net.Http;

namespace Frank.Libraries.Rest.Internal;

internal static class RequestExtensions
{
    public static HttpRequestMessage ToHttpRequestMessage(this IRequest request)
    {
        var httpRequestMessage = new HttpRequestMessage(request.Method.ToHttpMethod(), request.Url.ToString());

        httpRequestMessage.AddHeaders(request.Headers);
        httpRequestMessage.Content = new StringContent(request.Content ?? string.Empty);

        return httpRequestMessage;
    }
}