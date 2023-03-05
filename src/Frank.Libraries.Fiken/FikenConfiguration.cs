using Frank.Libraries.Fiken.Clients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Fiken;

/// <summary>
///     Represents a set of configuration settings for Fiken
/// </summary>
public class FikenConfiguration
{
    public string BaseUrl { get; set; } = "https://api.fiken.no/api/v2";
    public string Token { get; set; }
    public int Timeout { get; set; } = -1;
}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFiken(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FikenConfiguration>(configuration.GetSection(nameof(FikenConfiguration)));
        services.AddScoped<IAccountsClient, AccountsClient>();
        return services;
    }
}

public class FikenClient
{
    private readonly IOptions<FikenConfiguration> _options;


    public FikenClient(IAccountsClient accounts) => Accounts = accounts;

    public IAccountsClient Accounts { get; }
}