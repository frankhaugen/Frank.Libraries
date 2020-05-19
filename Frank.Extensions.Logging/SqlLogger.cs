using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Text.Json;

namespace Frank.Extensions.Logging
{
    public class SqlLogger : ILogger
    {
        private readonly string _name;
        private readonly string _connectionString;

        public SqlLogger(string name, string connectionString)
        {
            _name = name;
            _connectionString = connectionString;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var querybBuilder = new StringBuilder();

            querybBuilder.AppendLine($"INSERT INTO {nameof(LogItem)}s({nameof(LogItem.LogLevel)}, {nameof(LogItem.ApplicationName)}, {nameof(LogItem.Message)}, {nameof(LogItem.Type)}, {nameof(LogItem.EventId)}, {nameof(LogItem.EventName)}, {nameof(LogItem.Exception)}, {nameof(LogItem.DateTime)}, {nameof(LogItem.Name)})");
            querybBuilder.AppendLine($"VALUES('{logLevel}', '{AppDomain.CurrentDomain.FriendlyName}', '{formatter(state, exception)}', '{typeof(TState).Name}', '{eventId.Id}', '{eventId.Name}', '{JsonSerializer.Serialize(exception, new JsonSerializerOptions() { WriteIndented = true })}', '{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff}', '{_name}')");

            var query = querybBuilder.ToString();

            using var connection = new SqlConnection(_connectionString);
            using var sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            var failed = sqlCommand.ExecuteNonQuery() == 0;

            if (failed)
            {
                throw new Exception("Failed to add log entry");
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel >= LogLevel.Information;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
    }
}