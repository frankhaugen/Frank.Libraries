namespace Frank.Libraries.Currency;

public interface ICurrencyClient
{
    Task<Currency> GetLatestRatesAsync(CurrencyCode currencyCode = CurrencyCode.EUR);
    Task<decimal> ConvertAsync(decimal amount = 1, CurrencyCode fromCurrency = CurrencyCode.EUR, CurrencyCode toCurrency = CurrencyCode.EUR);
}