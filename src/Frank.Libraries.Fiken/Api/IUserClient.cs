using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IUserClient
{
    /// <summary>
    ///  Returns information about the user
    /// </summary>
    /// <returns>Userinfo</returns>
    Userinfo GetUser();
}