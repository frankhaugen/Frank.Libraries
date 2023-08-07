using Frank.Libraries.Fiken.Clients;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Fiken;

public class FikenClient
{
    private readonly IOptions<FikenConfiguration> _options;


    public FikenClient(IAccountsClient accounts) => Accounts = accounts;

    public IAccountsClient Accounts { get; }
}