using Frank.Libraries.Fiken.Client;
using Frank.Libraries.Fiken.Models;
using Microsoft.Extensions.Options;
using RestSharp;

namespace Frank.Libraries.Fiken.Api;

public abstract class BaseClient
{
    private Company? _company;

    protected BaseClient(IOptions<Configuration> options)
    {
        Configuration = options.Value;
        RestClient = new RestClient(Configuration.BaseUrl);
    }

    protected IRestClient RestClient { get; }
    protected Configuration Configuration { get; }
    protected Company Company => GetCompany();

    private Company GetCompany()
    {
        if (_company != null && !string.IsNullOrWhiteSpace(_company?.Slug)) return _company!;

        var request = GetBaseRestRequest(Method.GET, "/companies");
        var response = RestClient.Execute<List<Company>>(request);
        if (!response.IsSuccessful || !response.Data.Any()) throw new ApiException((int)response.StatusCode, response.ErrorMessage, response.Content);
        _company = response.Data.FirstOrDefault();

        return _company!;
    }

    protected IRestRequest GetBaseRestRequest(Method method, string resource)
    {
        var restRequest = new RestRequest(resource, method);
        restRequest.AddHeader("Authorization", $"Bearer {Configuration.Token}");
        return restRequest;
    }
}