using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Rest.Authentication;

public class BasicAuthenticator : IAuthenticator
{
    private readonly IOptions<BasicAuthenticatorOptions> _options;

    public BasicAuthenticator(IOptions<BasicAuthenticatorOptions> options, IHttpClientFactory httpClientFactory) => _options = options;

    public async Task<IRequest> AuthenticateAsync(IRequest request)
    {
        if (string.IsNullOrWhiteSpace(_options.Value.Username))
        {
            throw new AuthenticatorException("No username provided");
        }

        if (string.IsNullOrWhiteSpace(_options.Value.Password))
        {
            throw new AuthenticatorException("No password provided");
        }

        request.Headers.Add("basic", EncodeCredential(_options.Value.Username, _options.Value.Password));

        return request;
    }

    private static string EncodeCredential(string userName, string password) => Convert.ToBase64String(Encoding.UTF8.GetBytes($"{userName}:{password}"));
}