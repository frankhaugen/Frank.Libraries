using System;
using System.Threading.Tasks;
using RestSharp;

namespace Frank.Libraries.Currency
{
    public class CurrencyClient
    {
        private readonly string _fallbackApiKey = "3eb2343290d2f477028d3e6ef7c7e72e";
        private readonly string _apiKey;
        private readonly Uri _baseUri;
        private readonly RestClient _restClient;

        public CurrencyClient()
        {
            _apiKey = _fallbackApiKey;
            _baseUri = new Uri("http://data.fixer.io/api");
            _restClient = new RestClient(_baseUri) { FailOnDeserializationError = false, ThrowOnAnyError = false, ThrowOnDeserializationError = false };
            _restClient.AddDefaultQueryParameter("access_key", _apiKey);
        }

        public async Task<Currency> GetLatestRates(CurrencyCode currencyCode = CurrencyCode.EUR) => await _restClient.GetAsync<Currency>(new RestRequest("latest"));

        public async Task<decimal> Convert(decimal amount = 1, CurrencyCode fromCurrency = CurrencyCode.EUR, CurrencyCode toCurrency = CurrencyCode.EUR)
        {
            var baseCurrency = await GetLatestRates(fromCurrency);

            var baseRate = baseCurrency.Rates.GetRate(baseCurrency.Base);
            var targetRate = baseCurrency.Rates.GetRate(toCurrency);



            return default;
        }

    }
}
