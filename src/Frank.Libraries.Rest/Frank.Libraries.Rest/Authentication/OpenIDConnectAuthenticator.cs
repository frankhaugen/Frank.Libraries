using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;

namespace Frank.Libraries.Rest.Authentication;

public class OpenIDConnectAuthenticator : IAuthenticator
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IOptions<OpenIDConnectAuthenticatorOptions> _options;

    public OpenIDConnectAuthenticator(IOptions<OpenIDConnectAuthenticatorOptions> options, IHttpClientFactory httpClientFactory)
    {
        _options = options;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IRequest> AuthenticateAsync(IRequest request)
    {
        if (string.IsNullOrWhiteSpace(_options.Value.ClientId))
        {
            throw new AuthenticatorException("No ClientId provided");
        }

        if (string.IsNullOrWhiteSpace(_options.Value.ClientSecret))
        {
            throw new AuthenticatorException("No ClientSecret provided");
        }

        if (string.IsNullOrWhiteSpace(_options.Value.AuthCodeEndpoint))
        {
            throw new AuthenticatorException("No AuthCodeEndpoint provided");
        }

        if (string.IsNullOrWhiteSpace(_options.Value.WellKnownEndpoint))
        {
            throw new AuthenticatorException("No WellKnownEndpoint provided");
        }

        using var httpClient = _httpClientFactory.CreateClient();

        // get the authorization code from the user
        var authCodeResponse = await httpClient.GetAsync(_options.Value.AuthCodeEndpoint);
        if (!authCodeResponse.IsSuccessStatusCode)
        {
            throw new AuthenticatorException("Failed to get auth code");
        }

        var authCode = await authCodeResponse.Content.ReadAsStringAsync();

        // get the well known configuration
        var configResponse = await httpClient.GetStringAsync(_options.Value.WellKnownEndpoint);
        if (string.IsNullOrWhiteSpace(configResponse))
        {
            throw new AuthenticatorException("Failed to get OpenID Connect configuration");
        }

        var openIdConfig = new OpenIdConnectConfiguration(configResponse);

        // exchange the authorization code for an ID token
        var tokenResponse = await httpClient.PostAsync(openIdConfig.TokenEndpoint, new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("grant_type", "authorization_code"),
            new KeyValuePair<string, string>("code", authCode),
            new KeyValuePair<string, string>("redirect_uri", "your_redirect_uri"),
            new KeyValuePair<string, string>("client_id", _options.Value.ClientId),
            new KeyValuePair<string, string>("client_secret", _options.Value.ClientSecret)
        }));

        var json = await tokenResponse.Content.ReadAsStringAsync();
        var token = JsonSerializer.Deserialize<TokenResponse>(json)
                                  .IdToken;

        // validate the ID token
        var handler = new JwtSecurityTokenHandler();
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = openIdConfig.Issuer,
            ValidateAudience = true,
            ValidAudience = _options.Value.ClientId,
            ValidateLifetime = true
        };
        handler.ValidateToken(token, validationParameters, out _);

        // Add the token to the request
        request.Headers.Add("Bearer", token);

        return request;
    }

    private class TokenResponse
    {
        [JsonPropertyName("id_token")] public string IdToken { get; set; }
    }
}