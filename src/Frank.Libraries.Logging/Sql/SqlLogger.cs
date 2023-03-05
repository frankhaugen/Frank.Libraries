using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;

#pragma warning disable CA2100 // Review SQL queries for security vulnerabilities
namespace Frank.Libraries.Logging.Sql;

public class SqlLogger : ILogger
{
    private readonly SqlLoggerConfiguration _configuration;
    private readonly string _name;

    public SqlLogger(string name, SqlLoggerConfiguration configuration)
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

        var query = SqlQueryConstructor.ConstructQuery(logLevel, eventId, state, exception, formatter, _name);

        try
        {
            using var connection = new SqlConnection(_configuration.ConnectionString);
            using var sqlCommand = new SqlCommand(query, connection);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
        }
        catch
        {
            // Loggers don't throw
        }
    }

    public bool IsEnabled(LogLevel logLevel) => logLevel >= _configuration.LogLevel;

    public IDisposable BeginScope<TState>(TState state) => null!;
}