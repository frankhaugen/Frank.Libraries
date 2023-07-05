using System.Text.Json;
using System.Text.Json.Serialization;
using Frank.Libraries.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.DataStorage.Json;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddJsonDataStore(this IServiceCollection services, IConfiguration configuration, Action<IJsonDataStoreBuilder> configureRepositories)
    {
        services.AddSystemTextJsonSerializer(options =>
        {
            options.WriteIndented = false;
            options.Converters.Add(new JsonStringEnumConverter());
            options.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals;
            options.PropertyNameCaseInsensitive = true;
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
            options.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });
        services.Configure<JsonConfiguration>(configuration.GetSection(nameof(JsonConfiguration)));
        var builder = new JsonDataStoreBuilder(services);
        configureRepositories(builder);
        return services;
    }
}