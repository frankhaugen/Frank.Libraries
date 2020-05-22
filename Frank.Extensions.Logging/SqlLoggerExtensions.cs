using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace Frank.Extensions.Logging
{
    public static class SqlLoggerExtensions
    {
        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, IConfiguration configuration)
        {
            var sqlConfiguration = new SqlLoggerConfiguration()
            {
                LogLevel = Enum.Parse<LogLevel>(configuration["SqlLoggerConfiguration:LogLevel"]),
                ConnectionString = configuration["SqlLoggerConfiguration:ConnectionString"]
            };

            return AddLogger(loggerFactory, sqlConfiguration);
        }

        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, LogLevel logLevel, string connectionString)
        {
            var sqlConfiguration = new SqlLoggerConfiguration()
            {
                LogLevel = logLevel,
                ConnectionString = connectionString
            };

            return AddLogger(loggerFactory, sqlConfiguration);
        }

        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, SqlLoggerConfiguration sqlConfiguration)
        {
            return AddLogger(loggerFactory, sqlConfiguration);
        }

        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, Action<SqlLoggerConfiguration> sqlConfiguration)
        {
            var config = new SqlLoggerConfiguration();
            sqlConfiguration(config);
            return AddLogger(loggerFactory, config);
        }

        private static ILoggerFactory AddLogger(ILoggerFactory loggerFactory, SqlLoggerConfiguration sqlConfiguration)
        {
            if (string.IsNullOrWhiteSpace(sqlConfiguration.ConnectionString))
            {
                throw new ArgumentNullException(nameof(sqlConfiguration), $"'{nameof(SqlLoggerConfiguration)}.{nameof(SqlLoggerConfiguration.ConnectionString)}' cannot be null or empty");
            }

            loggerFactory.AddProvider(new SqlLoggerProvider(sqlConfiguration));

            return loggerFactory;
        }
    }
}