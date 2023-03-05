using System;
using Frank.Libraries.Logging.EntityFramework;
using Frank.Libraries.Logging.File;
using Frank.Libraries.Logging.Http;
using Frank.Libraries.Logging.XUnit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Frank.Libraries.Logging.Extensions;

public static class LoggerBuilderExtensions
{
    public static ILoggingBuilder AddEntityFrameworkLogger<TContext>(this ILoggingBuilder builder, Action<EntityFrameworkLoggerConfiguration> configuration) where TContext : DbContext
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.Services.Configure(configuration);
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, EntityFrameworkLoggerProvider<TContext>>());
        builder.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);
        return builder;
    }

    public static ILoggingBuilder AddHttpLogger<THttpClient>(this ILoggingBuilder builder, Action<HttpLoggerConfiguration> configuration) where THttpClient : IHttpLoggerClient
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.Services.Configure(configuration);
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, HttpLoggerProvider>());
        builder.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);
        return builder;
    }

    public static ILoggingBuilder AddFileLogger(this ILoggingBuilder builder, Action<FileLoggerConfiguration> configuration)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.Services.Configure(configuration);
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, FileLoggerProvider>());
        builder.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);
        return builder;
    }

    public static ILoggingBuilder AddTestLogger(this ILoggingBuilder builder, ITestOutputHelper outputHelper)
    {
        if (builder == null)
        {
            throw new ArgumentNullException(nameof(builder));
        }

        builder.AddProvider(new TestLoggerProvider(outputHelper));
        // builder.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);
        return builder;
    }
}