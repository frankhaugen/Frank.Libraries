using System.Data.Common;
using System.Linq.Expressions;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace Frank.Libraries.DataStorage.Sqlite;

public class SqliteClient : ISqliteClient
{
    private readonly SqliteConnection _connection;
    private bool _disposed;

    public SqliteClient(IConfiguration configuration)
    {
        _connection = new SqliteConnection(configuration.GetConnectionString(nameof(SqliteConnection)));
        _connection.OpenAsync().GetAwaiter().GetResult();
    }

    public async Task<int> ExecuteNonQueryAsync(string commandText)
    {
        await using var command = new SqliteCommand(commandText, _connection);
        return await command.ExecuteNonQueryAsync();
    }

    public async Task<object?> ExecuteScalarAsync(string commandText)
    {
        await using var command = new SqliteCommand(commandText, _connection);
        return await command.ExecuteScalarAsync();
    }

    public async Task<DbDataReader> ExecuteReaderAsync(string commandText)
    {
        await using var command = new SqliteCommand(commandText, _connection);
        return await command.ExecuteReaderAsync();
    }

    public async ValueTask DisposeAsync()
    {
        if (_disposed) return;
        await _connection.CloseAsync();
        await _connection.DisposeAsync();
        _disposed = true;
    }

    public void Dispose()
    {
        if (_disposed) return;
        DisposeAsync().AsTask().GetAwaiter().GetResult();
    }
}

public interface ISqliteClient : IDisposable, IAsyncDisposable
{

    Task<int> ExecuteNonQueryAsync(string commandText);
    Task<object?> ExecuteScalarAsync(string commandText);
    Task<DbDataReader> ExecuteReaderAsync(string commandText);
}

// public class SqliteContext
// {
//     private readonly SqliteConnectionManager _connectionManager;
//
//     public SqliteContext(SqliteConnectionManager connectionManager) => _connectionManager = connectionManager;
//
//     public async Task ExecuteNonQueryAsync(string sql, CancellationToken cancellationToken = default)
//     {
//         await using var connection = _connectionManager.Connection;
//         await connection.OpenAsync(cancellationToken);
//         await using var command = connection.CreateCommand();
//         command.CommandText = sql;
//         await command.ExecuteNonQueryAsync(cancellationToken);
//     }
//
//     public async Task<T> ExecuteScalarAsync<T>(string sql, CancellationToken cancellationToken = default)
//     {
//         await using var connection = _connectionManager.GetConnection();
//         await connection.OpenAsync(cancellationToken);
//         await using var command = connection.CreateCommand();
//         command.CommandText = sql;
//         var result = await command.ExecuteScalarAsync(cancellationToken) as T;
//         return result;
//     }
//
//     public async Task<IEnumerable<T>> QueryAsync<T>(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
//     {
//         var sql = SqliteQueryBuilder.BuildQuery(expression);
//         await using var connection = _connectionManager.GetConnection();
//         await connection.OpenAsync(cancellationToken);
//         await using var command = connection.CreateCommand();
//         command.CommandText = sql;
//         await using var reader = await command.ExecuteReaderAsync(cancellationToken);
//         var result = new List<T>();
//         while (await reader.ReadAsync(cancellationToken))
//         {
//             var item = Activator.CreateInstance<T>();
//             foreach (var property in typeof(T).GetProperties())
//             {
//                 var value = reader[property.Name];
//                 property.SetValue(item, value);
//             }
//
//             result.Add(item);
//         }
//
//         return result;
//     }
// }