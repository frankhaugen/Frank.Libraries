namespace Frank.Libraries.Rest.Authentication;

public class OpenIDConnectAuthenticatorOptions
{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string AuthCodeEndpoint { get; set; }
    public string WellKnownEndpoint { get; set; }
}