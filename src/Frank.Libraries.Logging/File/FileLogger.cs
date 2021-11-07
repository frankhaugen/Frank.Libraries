using System;
using System.Text.Json;
using Frank.Libraries.Logging.Shared;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.File
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
            if (!IsEnabled(logLevel)) return;

            var log = LogHelper.GetLog(_name, logLevel, eventId, state, exception, formatter);

            var line = $"{logLevel}{_configuration.Delimiter}{AppDomain.CurrentDomain.FriendlyName}{_configuration.Delimiter}{formatter(state, exception)}{_configuration.Delimiter}{typeof(TState).Name}{_configuration.Delimiter}{eventId.Id}{_configuration.Delimiter}{eventId.Name}{_configuration.Delimiter}{JsonSerializer.Serialize(exception)}{_configuration.Delimiter}{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff}{_configuration.Delimiter}{_name}";
            LogFileWriter.WriteString(line, _configuration.GetPath());
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
