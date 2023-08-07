using Frank.Libraries.Rest;

namespace Frank.Libraries.Currency;

public class CurrencyClient : ICurrencyClient
{
    private readonly string _apiKey;
    private readonly string _fallbackApiKey = "3eb2343290d2f477028d3e6ef7c7e72e";
    private readonly IRestClient _restClient;

    public CurrencyClient(IRestClient restClient)
    {
        _restClient = restClient;
        _apiKey = _fallbackApiKey;
    }

    public async Task<Currency> GetLatestRatesAsync(CurrencyCode currencyCode = CurrencyCode.EUR)
    {
        var request = new Request
        {
            Method = Method.Get,
            Url = new Url("data.fixer.io")
        };

        request.Url.AddPath("api/latest");
        request.Url.AddQueryParam("access_key", _apiKey);

        var response = await _restClient.SendAsync<Currency>(request);
        return response.Data;
    }

    public async Task<decimal> ConvertAsync(decimal amount = 1, CurrencyCode fromCurrency = CurrencyCode.EUR, CurrencyCode toCurrency = CurrencyCode.EUR)
    {
        var baseCurrency = await GetLatestRatesAsync(fromCurrency);

        // var baseRate = baseCurrency.Rates.GetRate(baseCurrency.Base);
        // var targetRate = baseCurrency.Rates.GetRate(toCurrency);

        return default;
    }
}