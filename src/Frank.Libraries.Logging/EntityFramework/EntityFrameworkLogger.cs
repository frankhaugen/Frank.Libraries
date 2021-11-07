using System;
using Frank.Libraries.Logging.Extensions;
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
            using var scope = _serviceProvider.CreateScope();
            using var context = ActivatorUtilities.CreateInstance<TContext>(scope.ServiceProvider);

            var log = new Log()
            {
                Timestamp = DateTime.UtcNow,
                EventId = eventId.Id,
                EventName = eventId.Name,
                Level = logLevel.ToString(),
                Message = exception.FlattenMessages(),
                Exception = exception.Message,
                Type = typeof(TState).Name,
                Name = _name,
                ApplicationName = AppDomain.CurrentDomain.FriendlyName
            };

            context.Set<Log>().Add(log);

            try
            {
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