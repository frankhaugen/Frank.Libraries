using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Rest.Authentication;

public class ApiKeyAuthenticator : IAuthenticator
{
    private readonly IOptions<ApiKeyAuthenticatorOptions> _options;

    public ApiKeyAuthenticator(IOptions<ApiKeyAuthenticatorOptions> options) => _options = options;

    public async Task<IRequest> AuthenticateAsync(IRequest request)
    {
        if (string.IsNullOrWhiteSpace(_options.Value.HeaderValue))
        {
            throw new AuthenticatorException("No HeaderValue provided");
        }

        if (string.IsNullOrWhiteSpace(_options.Value.HeaderName))
        {
            throw new AuthenticatorException("No HeaderName provided");
        }

        request.Headers.Add(_options.Value.HeaderName, _options.Value.HeaderValue);
        return request;
    }
}