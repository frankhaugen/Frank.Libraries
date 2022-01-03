using RestSharp;

namespace Frank.Libraries.Fiken.Clients;

public interface IAuthenticationClient
{
    string CompanySlug { get; }
    IRestRequest GetRequest(string resource, Method method = Method.GET);
    Task<T> ExecuteAsync<T>(IRestRequest request);
    T Execute<T>(IRestRequest request);
}