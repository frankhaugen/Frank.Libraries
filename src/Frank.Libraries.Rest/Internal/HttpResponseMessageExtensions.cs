using Frank.Libraries.Rest.Serialization;

namespace Frank.Libraries.Rest.Internal;

internal static class HttpResponseMessageExtensions
{
    public static async Task<IResponse<T>> ToResponseAsync<T>(this HttpResponseMessage httpResponseMessage, ISerializer serializer)
    {
        var content = await httpResponseMessage.Content.ReadAsStringAsync();

        return new Response<T>
        {
            StatusCode = httpResponseMessage.StatusCode,
            Content = content,
            ReasonPhrase = httpResponseMessage.ReasonPhrase,
            Headers = httpResponseMessage.Headers.ToDictionary(x => x.Key, x => string.Join((string?)";", (IEnumerable<string?>)x.Value)),
            IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode,
            Data = serializer.Deserialize<T>(content)
        };
    }

    public static async Task<IResponse> ToResponseAsync(this HttpResponseMessage httpResponseMessage)
    {
        var content = await httpResponseMessage.Content.ReadAsStringAsync();

        return new Response
        {
            StatusCode = httpResponseMessage.StatusCode,
            Content = content,
            ReasonPhrase = httpResponseMessage.ReasonPhrase,
            Headers = httpResponseMessage.Headers.ToDictionary(x => x.Key, x => string.Join(";", x.Value)),
            IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode
        };
    }
}