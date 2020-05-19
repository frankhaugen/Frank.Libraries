using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.Text;

namespace Frank.Extensions.Logging
{
    public class SqlLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, SqlLogger> _loggers = new ConcurrentDictionary<string, SqlLogger>();
        private readonly string _connectionString;

        public SqlLoggerProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public ILogger CreateLogger(string categoryName)
        {
            if (!TableExists())
            {
                CreateTable();
            }

            return _loggers.GetOrAdd(categoryName, name => new SqlLogger(name, _connectionString));
        }

        private bool TableExists()
        {
            var tableName = $"{nameof(LogItem)}s";
            var query = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='{tableName}'";

            using var connection = new SqlConnection(_connectionString);
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

            using var connection = new SqlConnection(_connectionString);
            using var sqlCommand = new SqlCommand(query.ToString(), connection);
            connection.Open();
            return sqlCommand.ExecuteNonQuery() > 0;
        }
    }
}