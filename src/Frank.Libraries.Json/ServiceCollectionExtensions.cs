using System.IO.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Json;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Add this to register dependencies for the Json Context
    /// </summary>
    public static void AddJsonDataStore<TEntity>(this IServiceCollection services, IConfiguration configuration) where TEntity : JsonEntity, new()
    {
        services.Configure<JsonConfiguration>(configuration.GetSection(nameof(JsonConfiguration)));
        services.AddSingleton<IJsonContext<TEntity>, JsonContext<TEntity>>();
        services.AddTransient<IFileSystem, FileSystem>();
    }

    /// <summary>
    ///    Add this to register dependencies for the Json Serializer
    /// </summary>
    public static void AddJsonSerializer(this IServiceCollection services)
    {
        services.AddSingleton<IJsonSerializer, JsonSerializer>();
    }
}