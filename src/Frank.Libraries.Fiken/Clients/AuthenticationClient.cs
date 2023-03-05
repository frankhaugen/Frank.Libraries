namespace Frank.Libraries.Fiken.Clients;

public class AuthenticationClient // : IAuthenticationClient
{
    // private readonly RestClient _restClient;
    // private readonly IOptions<FikenConfiguration> _options;
    // private Company _company;
    //
    // public AuthenticationClient(IOptions<FikenConfiguration> options, RestClient restClient)
    // {
    //     _options = options;
    //     _restClient = restClient;
    //     _restClient.BaseUrl = new Uri(_options.Value.BaseUrl);
    // }
    //
    // public string CompanySlug => Company.Slug;
    // private Company Company => GetCompany();
    //
    // public IRestRequest GetRequest(string resource, Method method = Method.GET)
    // {
    //     var request = new RestRequest(resource, method);
    //     request.AddHeader("Authorization", $"Bearer {_options.Value.Token}");
    //     return request;
    // }
    //
    // public async Task<T> ExecuteAsync<T>(IRestRequest request)
    // {
    //     var response = await _restClient.ExecuteAsync<T>(request);
    //     return response.Data;
    // }
    //
    // public T Execute<T>(IRestRequest request)
    // {
    //     var response = _restClient.Execute<T>(request);
    //     return response.Data;
    // }
    //
    // private Company GetCompany()
    // {
    //     if (_company != null && !string.IsNullOrWhiteSpace(_company?.Slug)) return _company!;
    //     _company = Execute<List<Company>>(GetRequest("companies")).FirstOrDefault();
    //     return _company;
    // }
}