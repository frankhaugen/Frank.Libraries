using System;
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
            var d = _configuration.Delimiter;
            var line = $"{log.Level}{d}{log.ApplicationName}{d}{log.Message}{d}{log.EventId}{d}{eventId.Id}{d}{eventId.Name}{d}{exception.Message}{d}{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff}{d}{_name}";
            LogFileWriter.WriteString(line.Replace(Environment.NewLine, @"\n"), _configuration.GetPath());
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