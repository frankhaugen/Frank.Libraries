using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace Frank.Libraries.Logging
{
    public static class FileLoggerExtensions
    {
        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            var fileConfiguration = new FileLoggerConfiguration()
            {
                LogLevel = Enum.Parse<LogLevel>(configuration["FileLoggerConfiguration:LogLevel"]),
                Path = configuration["FileLoggerConfiguration:Path"]
            };

            return AddLogger(loggerFactory, fileConfiguration);
        }

        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, LogLevel logLevel, string path)
        {
            var fileConfiguration = new FileLoggerConfiguration()
            {
                LogLevel = logLevel,
                Path = path
            };

            return AddLogger(loggerFactory, fileConfiguration);
        }

        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, FileLoggerConfiguration fileConfiguration)
        {
            return AddLogger(loggerFactory, fileConfiguration);
        }

        public static ILoggerFactory UseFileLogger(this ILoggerFactory loggerFactory, Action<FileLoggerConfiguration> fileConfiguration)
        {
            var config = new FileLoggerConfiguration();
            fileConfiguration(config);
            return AddLogger(loggerFactory, config);
        }

        private static ILoggerFactory AddLogger(ILoggerFactory loggerFactory, FileLoggerConfiguration fileConfiguration)
        {
            if (string.IsNullOrWhiteSpace(fileConfiguration.Path))
            {
                throw new ArgumentNullException(nameof(fileConfiguration), $"'{nameof(FileLoggerConfiguration)}.{nameof(FileLoggerConfiguration.Path)}' cannot be null or empty");
            }

            loggerFactory.AddProvider(new FileLoggerProvider(fileConfiguration));

            return loggerFactory;
        }
    }
}
