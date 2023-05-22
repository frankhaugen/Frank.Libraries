namespace Frank.Libraries.Tests.Currencies;

internal class TestHttpClientFactory : IHttpClientFactory
{
    public HttpClient CreateClient(string name = "") => new HttpClient();
}