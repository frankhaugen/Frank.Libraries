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

public interface ICurrencyClient
{
    Task<Currency> GetLatestRatesAsync(CurrencyCode currencyCode = CurrencyCode.EUR);
    Task<decimal> ConvertAsync(decimal amount = 1, CurrencyCode fromCurrency = CurrencyCode.EUR, CurrencyCode toCurrency = CurrencyCode.EUR);
}