using System;
using Frank.Libraries.Logging.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Extensions
{
    public static class LoggerBuilderExtensions
    {
        public static ILoggingBuilder AddEntityFrameworkLogger<TContext>(this ILoggingBuilder builder) where TContext : DbContext
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, EntityFrameworkLoggerProvider<TContext>>());

            return builder;
        }
    }
}