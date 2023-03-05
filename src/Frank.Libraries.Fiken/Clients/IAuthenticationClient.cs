using RestSharp;

namespace Frank.Libraries.Fiken.Clients;

public interface IAuthenticationClient
{
    string CompanySlug { get; }
    RestRequest GetRequest(string resource, Method method = Method.Get);
    Task<T> ExecuteAsync<T>(RestRequest request);
    T Execute<T>(RestRequest request);
}