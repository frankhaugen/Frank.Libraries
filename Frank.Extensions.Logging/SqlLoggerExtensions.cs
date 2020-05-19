using Microsoft.Extensions.Logging;

namespace Frank.Extensions.Logging
{
    public static class SqlLoggerExtensions
    {
        public static ILoggingBuilder AddSqlLogger(this ILoggingBuilder loggingBuilder, string connectionString)
        {
            loggingBuilder.AddProvider(new SqlLoggerProvider(connectionString));

            return loggingBuilder;
        }

        public static ILoggerFactory UseSqlLogger(this ILoggerFactory loggerFactory, string connectionString)
        {
            loggerFactory.AddProvider(new SqlLoggerProvider(connectionString));

            return loggerFactory;
        }
    }
}