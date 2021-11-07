using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.Text;
using Frank.Libraries.Logging.EntityFramework;
using Frank.Libraries.Logging.Exceptions;
using Frank.Libraries.Logging.Shared;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Sql
{
    public sealed class SqlLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, SqlLogger> _loggers = new ConcurrentDictionary<string, SqlLogger>();
        private readonly SqlLoggerConfiguration _configuration;

        public SqlLoggerProvider(SqlLoggerConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public ILogger CreateLogger(string categoryName)
        {
            if (TableExists()) return _loggers.GetOrAdd(categoryName, name => new SqlLogger(name, _configuration));
            if (CreateTable()) return _loggers.GetOrAdd(categoryName, name => new SqlLogger(name, _configuration));
            throw new LoggerException<SqlLogger>("A table could not be found or created. Make sure your connection string is correct");
        }

        private bool TableExists()
        {
            var tableName = $"{nameof(Log)}s";
            var query = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='{tableName}'";

            using var connection = new SqlConnection(_configuration.ConnectionString);
            using var sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            var result = sqlCommand.ExecuteScalar();

            return tableName == (string)result;
        }

        private bool CreateTable()
        {
            var query = new StringBuilder();
            query.AppendLine($"CREATE TABLE {nameof(Log)}s");
            query.AppendLine("(");
            query.AppendLine($"{nameof(Log.Id)} [bigint] NOT NULL IDENTITY(1, 1) PRIMARY KEY,");
            query.AppendLine($"{nameof(Log.Level)} varchar(32),");
            query.AppendLine($"{nameof(Log.ApplicationName)} varchar(256),");
            query.AppendLine($"{nameof(Log.Message)} varchar(5120),");
            query.AppendLine($"{nameof(Log.Type)} varchar(256),");
            query.AppendLine($"{nameof(Log.EventId)} varchar(256),");
            query.AppendLine($"{nameof(Log.EventName)} varchar(256),");
            query.AppendLine($"{nameof(Log.Exception)} varchar(5120),");
            query.AppendLine($"{nameof(Log.Timestamp)} [datetime2],");
            query.AppendLine($"{nameof(Log.Name)} varchar(256),");
            query.AppendLine(")");

            using var connection = new SqlConnection(_configuration.ConnectionString);
#pragma warning disable CA2100 // Review SQL queries for security vulnerabilities
            using var sqlCommand = new SqlCommand(query.ToString(), connection);
#pragma warning restore CA2100 // Review SQL queries for security vulnerabilities
            connection.Open();
            return sqlCommand.ExecuteNonQuery() > 0;
        }
    }
}
