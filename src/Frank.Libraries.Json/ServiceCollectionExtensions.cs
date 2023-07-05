using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Json;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///   Add this to register dependencies for the Json Serializer using your own implementation
    ///   Use SystemTextJsonSerializer if you want to use the default implementation from Microsoft and this library
    /// </summary>
    /// <param name="services"></param>
    /// <typeparam name="TService"></typeparam>
    /// <returns></returns>
    public static IServiceCollection AddJsonSerializer<TService>(this IServiceCollection services) where TService : class, IJsonSerializer
    {
        services.AddSingleton<IJsonSerializer, TService>();
        return services;
    }

    /// <summary>
    ///    Add this to register dependencies for the Json Serializer
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configureOptions"></param>
    /// <returns></returns>
    public static void AddSystemTextJsonSerializer(this IServiceCollection services, Action<JsonSerializerOptions>? configureOptions = null)
    {
        services.Configure(configureOptions ?? (options =>
        {
            options.WriteIndented = true;
            options.Converters.Add(new JsonStringEnumConverter());
            options.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals;
            options.PropertyNameCaseInsensitive = true;
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
            options.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        }));
        services.AddJsonSerializer<SystemTextJsonSerializer>();
    }
}