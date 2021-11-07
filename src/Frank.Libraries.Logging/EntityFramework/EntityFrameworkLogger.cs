using System;
using Frank.Libraries.Logging.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.EntityFramework
{
    public class EntityFrameworkLogger<TContext> : ILogger
    where TContext : DbContext
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string _name;
        private readonly EntityFrameworkLoggerConfiguration _configuration;

        public EntityFrameworkLogger(IServiceProvider serviceProvider, EntityFrameworkLoggerConfiguration configuration, string name)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _configuration = configuration;
            _name = name;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel)) return;

            var log = LogHelper.GetLog(_name, logLevel, eventId, state, exception, formatter);

            try
            {
                using var scope = _serviceProvider.CreateScope();
                using var context = scope.ServiceProvider.GetRequiredService<TContext>();
                context.Set<Log>().Add(log);
                context.SaveChanges();
            }
            catch
            {
                // loggers don't throw
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= _configuration.LogLevel;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null!;
        }
    }
}