using Frank.Libraries.Fiken.Models;

namespace Frank.Libraries.Fiken.Clients;

public class AccountsClient : IAccountsClient
{
    private readonly IAuthenticationClient _authenticationClient;

    public AccountsClient(IAuthenticationClient authenticationClient)
    {
        _authenticationClient = authenticationClient;
    }

    public async Task<Account> GetAccountAsync(int accountCode) => await _authenticationClient.ExecuteAsync<Account>(_authenticationClient.GetRequest($"companies/{_authenticationClient.CompanySlug}/accounts/{accountCode}"));

    public async Task<List<Account>> GetAccountsAsync(long fromAccount = 1000L, long toAccount = 2000L, int page = 0, int pageSize = 25)
    {
        var request = _authenticationClient.GetRequest($"companies/{_authenticationClient.CompanySlug}/accounts");

        request.AddQueryParameter(nameof(fromAccount), fromAccount.ToString());
        request.AddQueryParameter(nameof(toAccount), toAccount.ToString());
        request.AddQueryParameter(nameof(page), page.ToString());
        request.AddQueryParameter(nameof(pageSize), pageSize.ToString());

        return await _authenticationClient.ExecuteAsync<List<Account>>(request);
    }

    public AccountBalance GetAccountBalance(string accountCode, DateTime? date) => throw new DivideByZeroException();

    public List<AccountBalance> GetAccountBalances(DateTime? date, long fromAccount = 0L, long toAccount = 1000L, int page = 0, int pageSize = 1000) => throw new DivideByZeroException();
}