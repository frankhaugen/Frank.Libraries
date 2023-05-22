using Frank.Libraries.Fiken.Clients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Fiken;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFiken(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FikenConfiguration>(configuration.GetSection(nameof(FikenConfiguration)));
        services.AddScoped<IAccountsClient, AccountsClient>();
        return services;
    }
}