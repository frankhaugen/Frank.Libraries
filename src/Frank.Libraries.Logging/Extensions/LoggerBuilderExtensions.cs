using System;
using Frank.Libraries.Logging.EntityFramework;
using Frank.Libraries.Logging.File;
using Frank.Libraries.Logging.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Extensions
{
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

        public static ILoggingBuilder AddHttpLogger<TContext>(this ILoggingBuilder builder, Action<EntityFrameworkLoggerConfiguration> configuration) where TContext : DbContext
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

        public static ILoggingBuilder AddFileLogger<TContext>(this ILoggingBuilder builder, Action<FileLoggerConfiguration> configuration) where TContext : DbContext
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
    }
}