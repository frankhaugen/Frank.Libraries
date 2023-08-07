using Frank.Libraries.Rest;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Currency;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCurrencyClient(this IServiceCollection services)
    {
        services.AddRestClient();
        services.AddSingleton<ICurrencyClient, CurrencyClient>();
        return services;
    }
}