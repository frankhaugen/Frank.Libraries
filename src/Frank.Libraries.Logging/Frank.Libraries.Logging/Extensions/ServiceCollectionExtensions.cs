using Frank.Libraries.Logging.EntityFramework;
using Frank.Libraries.Logging.File;
using Frank.Libraries.Logging.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Frank.Libraries.Logging.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEntityFrameworkLogger<TContext>(this IServiceCollection services, Action<EntityFrameworkLoggerConfiguration> configuration) where TContext : DbContext
    {
        services.AddLogging(builder => builder.AddEntityFrameworkLogger<TContext>(configuration));
        return services;
    }

    public static IServiceCollection AddHttpLogger<THttpClient>(this IServiceCollection services, Action<HttpLoggerConfiguration> configuration) where THttpClient : IHttpLoggerClient
    {
        services.AddLogging(builder => builder.AddHttpLogger<THttpClient>(configuration));
        return services;
    }

    public static IServiceCollection AddFileLogger(this IServiceCollection services, Action<FileLoggerConfiguration> configuration)
    {
        services.AddLogging(builder => builder.AddFileLogger(configuration));
        return services;
    }

    public static IServiceCollection AddTestLogger(this IServiceCollection services, ITestOutputHelper outputHelper)
    {
        services.AddLogging(builder => builder.ClearProviders()
                                              .AddTestLogger(outputHelper));
        return services;
    }
}