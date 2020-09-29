using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Text.Json;

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

            var line = $"{logLevel};{AppDomain.CurrentDomain.FriendlyName};{formatter(state, exception)};{typeof(TState).Name};{eventId.Id};{eventId.Name};{JsonSerializer.Serialize(exception, new JsonSerializerOptions() { WriteIndented = true })};{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff};{_name}";
            File.AppendAllLines(Path.Combine(_configuration.Path, "logs.csv"), new[] { line });
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
