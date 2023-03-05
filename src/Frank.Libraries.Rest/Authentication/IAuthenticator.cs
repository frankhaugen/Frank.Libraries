using System.Threading.Tasks;

namespace Frank.Libraries.Rest.Authentication;

/// <summary>
///     An authenticator is expected to use Dependency Injection and IOptions -pattern, and expose a IServiceCollection
///     extension-methods to register it
///     Best practice is to use IHttpClientFactory, but this isn't required
/// </summary>
public interface IAuthenticator
{
    /// <summary>
    ///     This is expected to append the authentication information to the request
    /// </summary>
    /// <param name="request"></param>
    /// <returns>An authenicated request</returns>
    Task<IRequest> AuthenticateAsync(IRequest request);
}