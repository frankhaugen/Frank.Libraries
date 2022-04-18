using System;
using System.Net.Http;
using System.Threading.Tasks;
using Frank.Libraries.Logging.Shared;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Frank.Libraries.Logging.Http
{
    public interface IHttpLoggerClient
    {
        void SendLog(Uri endpoint, Log log);
    }

    public class HttpLogger : ILogger
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string _name;
        private readonly HttpLoggerConfiguration _configuration;

        public HttpLogger(IServiceProvider serviceProvider, HttpLoggerConfiguration configuration, string name)
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
                Task.Run(() =>
                {
                    using var scope = _serviceProvider.CreateScope();
                    var client = scope.ServiceProvider.GetRequiredService<IHttpLoggerClient>();
                    client.SendLog(_configuration.Endpoint, log);
                });
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