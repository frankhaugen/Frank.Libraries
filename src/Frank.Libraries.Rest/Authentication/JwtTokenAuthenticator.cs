using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Rest.Authentication;

internal class JwtTokenAuthenticator : IAuthenticator
{
    private readonly IOptions<JwtTokenAuthenticatorOptions> _options;

    public JwtTokenAuthenticator(IOptions<JwtTokenAuthenticatorOptions> options) => _options = options;

    public async Task<IRequest> AuthenticateAsync(IRequest request)
    {
        if (string.IsNullOrWhiteSpace(_options.Value.Token))
        {
            throw new AuthenticatorException("No token provided");
        }

        request.Headers.Add("Authorization", $"Bearer {_options.Value.Token}");
        return request;
    }
}