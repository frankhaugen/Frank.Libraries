using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging
{
    public class SqlLoggerProvider : ILoggerProvider
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
            throw new SqlLoggerException("A table could not be found or created. Make sure your connection string is correct");
        }

        private bool TableExists()
        {
            var tableName = $"{nameof(LogItem)}s";
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
            query.AppendLine($"CREATE TABLE {nameof(LogItem)}s");
            query.AppendLine("(");
            query.AppendLine($"{nameof(LogItem.Id)} [bigint] NOT NULL IDENTITY(1, 1) PRIMARY KEY,");
            query.AppendLine($"{nameof(LogItem.LogLevel)} varchar(32),");
            query.AppendLine($"{nameof(LogItem.ApplicationName)} varchar(256),");
            query.AppendLine($"{nameof(LogItem.Message)} varchar(5120),");
            query.AppendLine($"{nameof(LogItem.Type)} varchar(256),");
            query.AppendLine($"{nameof(LogItem.EventId)} varchar(256),");
            query.AppendLine($"{nameof(LogItem.EventName)} varchar(256),");
            query.AppendLine($"{nameof(LogItem.Exception)} varchar(5120),");
            query.AppendLine($"{nameof(LogItem.DateTime)} [datetime2],");
            query.AppendLine($"{nameof(LogItem.Name)} varchar(256),");
            query.AppendLine(")");

            using var connection = new SqlConnection(_configuration.ConnectionString);
            using var sqlCommand = new SqlCommand(query.ToString(), connection);
            connection.Open();
            return sqlCommand.ExecuteNonQuery() > 0;
        }
    }
}