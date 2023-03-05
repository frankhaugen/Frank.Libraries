using System.Net.Http;
using System.Threading.Tasks;
using Frank.Libraries.Rest.Authentication;
using Frank.Libraries.Rest.Internal;
using Frank.Libraries.Rest.Serialization;

namespace Frank.Libraries.Rest;

public class RestClient : IRestClient
{
    private readonly IAuthenticator _authenticator;
    private readonly IHttpClientFactory _httpClientFactory;

    public RestClient(IHttpClientFactory httpClientFactory, ISerializer serializer, IAuthenticator authenticator)
    {
        _httpClientFactory = httpClientFactory;
        Serializer = serializer;
        _authenticator = authenticator;
    }

    public ISerializer Serializer { get; }

    public async Task<IResponse<T>> SendAsync<T>(IRequest request)
    {
        _authenticator.AuthenticateAsync(request);
        var httpRequestMessage = request.ToHttpRequestMessage();
        using var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var response = await httpResponseMessage.ToResponseAsync<T>(Serializer);
        return response;
    }

    public async Task<IResponse> SendAsync(IRequest request)
    {
        _authenticator.AuthenticateAsync(request);
        var httpRequestMessage = request.ToHttpRequestMessage();
        using var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
        var response = await httpResponseMessage.ToResponseAsync();
        return response;
    }
}