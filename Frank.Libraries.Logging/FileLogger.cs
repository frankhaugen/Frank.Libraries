using Microsoft.Extensions.Logging;
using System;

namespace Frank.Libraries.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _name;
        private readonly FileLoggerConfiguration _configuration;

        public FileLogger(string name, FileLoggerConfiguration configuration)
        {
            _name = name;
            _configuration = configuration;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
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
