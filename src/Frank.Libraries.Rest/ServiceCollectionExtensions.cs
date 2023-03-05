using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Web;
using Frank.Libraries.Rest.Authentication;
using Frank.Libraries.Rest.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Rest;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddRestClient(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddSingleton<IRestClient, RestClient>();
        services.AddSingleton<IAuthenticator, NullAuthenticator>();
        services.AddSingleton<ISerializer, DefaultSerializer>();

        return services;
    }

    public static IServiceCollection AddRestClient<TAuthenticator, TSerializer>(this IServiceCollection services) where TAuthenticator : class, IAuthenticator where TSerializer : class, ISerializer
    {
        services.AddHttpClient();
        services.AddSingleton<IRestClient, RestClient>();
        services.AddSingleton<IAuthenticator, TAuthenticator>();
        services.AddSingleton<ISerializer, TSerializer>();

        return services;
    }
}

public interface IResponse
{
    HttpStatusCode StatusCode { get; }
    string? Content { get; }
    string ReasonPhrase { get; }
    IReadOnlyDictionary<string, string> Headers { get; }
    public bool IsSuccessStatusCode { get; }
}

public class Response<T> : Response, IResponse<T>
{
    public T? Data { get; init; }
}

