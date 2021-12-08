using Frank.Libraries.Fiken.Client;
using Frank.Libraries.Fiken.Models;
using Microsoft.Extensions.Options;
using RestSharp;

namespace Frank.Libraries.Fiken.Api;

public class AccountsClient : BaseClient, IAccountsClient
{
    public AccountsClient(IOptions<Configuration> options) : base(options)
    {
    }

    public async Task<Account> GetAccountAsync(string accountCode)
    {
        var request = GetBaseRestRequest(Method.GET, "/companies/{companySlug}/accounts/{accountCode}");
        request.AddUrlSegment("companySlug", Company.Slug);
        request.AddUrlSegment(nameof(accountCode), accountCode);

        var response = await RestClient.ExecuteAsync<Account>(request);
        if (!response.IsSuccessful) throw new ApiException((int)response.StatusCode, response.ErrorMessage, response.Content);

        return response.Data;
    }

    public async Task<List<Account>> GetAccountsAsync(long fromAccount = 0L, long toAccount = 1000L, int page = 1, int pageSize = 25)
    {
        var request = GetBaseRestRequest(Method.GET, "/companies/{companySlug}/accounts");
        request.AddUrlSegment("companySlug", Company.Slug);

        request.AddQueryParameter(nameof(fromAccount), fromAccount.ToString());
        request.AddQueryParameter(nameof(toAccount), toAccount.ToString());
        request.AddQueryParameter(nameof(page), page.ToString());
        request.AddQueryParameter(nameof(pageSize), pageSize.ToString());

        var response = await RestClient.ExecuteAsync<List<Account>>(request);
        if (!response.IsSuccessful) throw new ApiException((int)response.StatusCode, response.ErrorMessage, response.Content);

        return response.Data;
    }

    public AccountBalance GetAccountBalance(string accountCode, DateTime? date) => throw new NotImplementedException();

    public List<AccountBalance> GetAccountBalances(DateTime? date, long fromAccount = 0L, long toAccount = 1000L, int page = 0, int pageSize = 1000) => throw new NotImplementedException();

}