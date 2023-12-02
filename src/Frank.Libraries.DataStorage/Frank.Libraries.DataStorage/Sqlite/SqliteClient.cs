using System.Data;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.Sqlite;

public class SqliteClient : ISqliteClient
{
    private readonly SqliteConnection _connection;
    private readonly SqliteTypeMapper _sqliteTypeMapper = new();
    private bool _disposed;

    public SqliteClient(IOptions<SqliteConnection> options) => _connection = new SqliteConnection(options.Value.ConnectionString);

    private static string GetTableName<T>() where T : class, IKeyed, new() => typeof(T).GetDisplayName();

    public void EnsureTableExists<T>() where T : class, IKeyed, new()
    {
        var tableName = GetTableName<T>();
        var tableExistsQuery = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}';";

        using (var command = new SqliteCommand(tableExistsQuery, _connection))
        {
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();

            if (result != null && result.ToString() == tableName)
            {
                // Table exists, no need to create
                return;
            }
        }

        var createTableStatement = _sqliteTypeMapper.CreateTableIfNotExistsStatement<T>();
        using var createTableCommand = new SqliteCommand(createTableStatement, _connection);
        _connection.Open();
        createTableCommand.ExecuteNonQuery();
        _connection.Close();
    }

    public T? GetById<T>(Guid id) where T : class, IKeyed, new()
    {
        var all = GetAll<T>();
        var result = all.FirstOrDefault(x => x.Id == id);
        return result;
    }

    public IEnumerable<T> GetAll<T>() where T : class, IKeyed, new()
    {
        var entities = new List<T>();
        var tableName = GetTableName<T>();
        var getAllStatement = $"SELECT * FROM {tableName};";
        _connection.Open();

        using var command = new SqliteCommand(getAllStatement, _connection);
        using var reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            var properties = typeof(T).GetProperties();

            var dataTable = new DataTable(GetTableName<T>());
            dataTable.Load(reader);

            foreach (DataRow row in dataTable.Rows)
            {
                ProcessDatarow(properties, dataTable, row, entities);
            }
        }

        _connection.Close();

        return entities;
    }


    public void Insert<T>(T entity) where T : class, IKeyed, new()
    {
        var tableName = GetTableName<T>();
        var properties = typeof(T).GetProperties();

        var columns = new List<string>();
        var values = new List<string>();
        foreach (var property in properties)
        {
            columns.Add(property.Name);
            values.Add($"@{property.Name}");
        }

        var insertStatement = $"INSERT INTO {tableName} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", values)});";

        using (var command = new SqliteCommand(insertStatement, _connection))
        {
            foreach (var property in properties)
            {
                command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity));
            }

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }

    public void Update<T>(T entity) where T : class, IKeyed, new()
    {
        var tableName = GetTableName<T>();
        var properties = typeof(T).GetProperties();

        var columns = new List<string>();
        foreach (var property in properties)
        {
            columns.Add($"{property.Name} = @{property.Name}");
        }

        var updateStatement = $"UPDATE {tableName} SET {string.Join(", ", columns)} WHERE Id = @Id;";

        using (var command = new SqliteCommand(updateStatement, _connection))
        {
            foreach (var property in properties)
            {
                command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(entity));
            }

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }

    public void Delete<T>(T entity) where T : class, IKeyed, new()
    {
        var tableName = GetTableName<T>();
        var deleteStatement = $"DELETE FROM {tableName} WHERE Id = @Id;";

        using (var command = new SqliteCommand(deleteStatement, _connection))
        {
            command.Parameters.AddWithValue("@Id", entity.Id);

            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }

    public void Dispose()
    {
        if (!_disposed)
        {
            _connection?.Dispose();
            _disposed = true;
        }

        GC.SuppressFinalize(this);
    }

    private static void ProcessDatarow<T>(PropertyInfo[] properties, DataTable dataTable, DataRow row, List<T> entities) where T : class, IKeyed, new()
    {
        var entity = new T();
        foreach (var property in properties)
        {
            var fieldName = property.Name;
            var fieldType = property.PropertyType;
            var fieldExists = dataTable.Columns.Contains(fieldName);

            if (fieldExists)
            {
                var index = dataTable.Columns.IndexOf(fieldName);
                var value = row[index];

                if (value == DBNull.Value)
                {
                    continue;
                }

                SetPropertyValue(fieldType, property, entity, value);
            }
        }

        entities.Add(entity);
    }

    private static void SetPropertyValue<T>(Type fieldType, PropertyInfo property, T entity, object value) where T : class, IKeyed, new()
    {
        if (fieldType == typeof(Guid))
        {
            property.SetValue(entity, Guid.Parse(value.ToString()));
        }
        else if (fieldType == typeof(Guid?))
        {
            property.SetValue(entity, Guid.TryParse(value.ToString(), out var guid)
                                  ? guid
                                  : null);
        }
        else if (fieldType == typeof(int))
        {
            property.SetValue(entity, Convert.ToInt32(value));
        }
        else if (fieldType == typeof(int?))
        {
            property.SetValue(entity, Convert.ToInt32(value));
        }
        else if (fieldType == typeof(long))
        {
            property.SetValue(entity, Convert.ToInt64(value));
        }
        else if (fieldType == typeof(long?))
        {
            property.SetValue(entity, Convert.ToInt64(value));
        }
        else if (fieldType == typeof(short))
        {
            property.SetValue(entity, Convert.ToInt16(value));
        }
        else if (fieldType == typeof(short?))
        {
            property.SetValue(entity, Convert.ToInt16(value));
        }
        else if (fieldType == typeof(byte))
        {
            property.SetValue(entity, Convert.ToByte(value));
        }
        else if (fieldType == typeof(byte?))
        {
            property.SetValue(entity, Convert.ToByte(value));
        }
        else if (fieldType == typeof(uint))
        {
            property.SetValue(entity, Convert.ToUInt32(value));
        }
        else if (fieldType == typeof(uint?))
        {
            property.SetValue(entity, Convert.ToUInt32(value));
        }
        else if (fieldType == typeof(ulong))
        {
            property.SetValue(entity, Convert.ToUInt64(value));
        }
        else if (fieldType == typeof(ulong?))
        {
            property.SetValue(entity, Convert.ToUInt64(value));
        }
        else if (fieldType == typeof(ushort))
        {
            property.SetValue(entity, Convert.ToUInt16(value));
        }
        else if (fieldType == typeof(ushort?))
        {
            property.SetValue(entity, Convert.ToUInt16(value));
        }
        else if (fieldType == typeof(sbyte))
        {
            property.SetValue(entity, Convert.ToSByte(value));
        }
        else if (fieldType == typeof(sbyte?))
        {
            property.SetValue(entity, Convert.ToSByte(value));
        }
        else if (fieldType == typeof(char))
        {
            property.SetValue(entity, Convert.ToChar(value));
        }
        else if (fieldType == typeof(char?))
        {
            property.SetValue(entity, Convert.ToChar(value));
        }
        else if (fieldType == typeof(string))
        {
            property.SetValue(entity, Convert.ToString(value));
        }
        else if (fieldType == typeof(DateTime))
        {
            property.SetValue(entity, Convert.ToDateTime(value));
        }
        else if (fieldType == typeof(DateTime?))
        {
            property.SetValue(entity, Convert.ToDateTime(value));
        }
        else if (fieldType == typeof(bool))
        {
            property.SetValue(entity, Convert.ToBoolean(value));
        }
        else if (fieldType == typeof(bool?))
        {
            property.SetValue(entity, Convert.ToBoolean(value));
        }
        else if (fieldType == typeof(decimal))
        {
            property.SetValue(entity, Convert.ToDecimal(value));
        }
        else if (fieldType == typeof(decimal?))
        {
            property.SetValue(entity, Convert.ToDecimal(value));
        }
        else if (fieldType == typeof(TimeSpan))
        {
            property.SetValue(entity, TimeSpan.Parse(value.ToString()));
        }
        else if (fieldType == typeof(TimeSpan?))
        {
            property.SetValue(entity, TimeSpan.TryParse(value.ToString(), out var timeSpan)
                                  ? timeSpan
                                  : null);
        }
        else if (fieldType == typeof(DateTimeOffset))
        {
            property.SetValue(entity, DateTimeOffset.Parse(value.ToString()));
        }
        else if (fieldType == typeof(DateTimeOffset?))
        {
            property.SetValue(entity, DateTimeOffset.TryParse(value.ToString(), out var dateTimeOffset)
                                  ? dateTimeOffset
                                  : null);
        }
        else if (fieldType == typeof(byte[]))
        {
            property.SetValue(entity, (byte[])value);
        }
        else
        {
            Debugger.Break();
        }
    }
}