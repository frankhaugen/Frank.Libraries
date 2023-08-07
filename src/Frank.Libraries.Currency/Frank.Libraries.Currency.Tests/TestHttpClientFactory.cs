namespace Frank.Libraries.Currency.Tests;

internal class TestHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient(string name = "") => new HttpClient();
}