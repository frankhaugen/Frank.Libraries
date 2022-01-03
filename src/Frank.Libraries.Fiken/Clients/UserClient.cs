using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

public class UserClient : IUserClient
{
    private readonly IAuthenticationClient _authenticationClient;

    public UserClient(IAuthenticationClient authenticationClient)
    {
        _authenticationClient = authenticationClient;
    }

    public Userinfo GetUser() => _authenticationClient.Execute<Userinfo>(_authenticationClient.GetRequest("user"));
}