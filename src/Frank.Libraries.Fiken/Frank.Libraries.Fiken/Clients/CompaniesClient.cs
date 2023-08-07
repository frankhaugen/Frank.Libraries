using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

public class CompaniesClient : ICompaniesClient
{
    private readonly IAuthenticationClient _authenticationClient;

    public CompaniesClient(IAuthenticationClient authenticationClient) => _authenticationClient = authenticationClient;

    public List<Company> GetCompanies(int? page, int? pageSize, string sortBy) => _authenticationClient.Execute<List<Company>>(_authenticationClient.GetRequest("companies"));

    public Company GetCompany(string companySlug) => _authenticationClient.Execute<Company>(_authenticationClient.GetRequest($"companies/{companySlug}"));
}