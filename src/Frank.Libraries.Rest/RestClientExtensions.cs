namespace Frank.Libraries.Rest;

public static class RestClientExtensions
{
    public static async Task<IResponse<T>> PostAsync<T>(this IRestClient restClient, IUrl url, object body = null)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Post,
            Content = restClient.Serializer.Serialize(body)
        };
        return await restClient.SendAsync<T>(request);
    }

    public static async Task<IResponse> PostAsync(this IRestClient restClient, IUrl url, object body = null)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Post,
            Content = restClient.Serializer.Serialize(body)
        };
        return await restClient.SendAsync(request);
    }

    public static async Task<IResponse<T>> GetAsync<T>(this IRestClient restClient, IUrl url)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Get
        };
        return await restClient.SendAsync<T>(request);
    }

    public static async Task<IResponse> GetAsync(this IRestClient restClient, IUrl url)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Get
        };
        return await restClient.SendAsync(request);
    }

    public static async Task<IResponse<T>> PutAsync<T>(this IRestClient restClient, IUrl url, object body = null)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Put,
            Content = restClient.Serializer.Serialize(body)
        };
        return await restClient.SendAsync<T>(request);
    }

    public static async Task<IResponse> PutAsync(this IRestClient restClient, IUrl url, object body = null)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Put,
            Content = restClient.Serializer.Serialize(body)
        };
        return await restClient.SendAsync(request);
    }

    public static async Task<IResponse<T>> DeleteAsync<T>(this IRestClient restClient, IUrl url)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Delete
        };
        return await restClient.SendAsync<T>(request);
    }

    public static async Task<IResponse> DeleteAsync(this IRestClient restClient, IUrl url)
    {
        var request = new Request
        {
            Url = url,
            Method = Method.Delete
        };
        return await restClient.SendAsync(request);
    }
}