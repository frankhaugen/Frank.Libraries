namespace Frank.Libraries.Rest.Authentication;

/// <summary>
///     This authenticator does nothing
/// </summary>
/// s
public class NullAuthenticator : IAuthenticator
{
    public async Task<IRequest> AuthenticateAsync(IRequest request) => request;
}