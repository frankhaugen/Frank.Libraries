using System.Reflection;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.Sqlite;

internal class SqliteTypeMapper
{
    private readonly SqliteTypeMappingDefinition _typeMappingDefinition;

    public SqliteTypeMapper() => _typeMappingDefinition = new SqliteTypeMappingDefinition();

    public string CreateTableIfNotExistsStatement<T>() where T : class, IKeyed, new()
    {
        var tableName = typeof(T).GetDisplayName();
        var properties = typeof(T).GetProperties();

        var columns = new List<string>();
        foreach (var property in properties)
        {
            columns.Add(CreateTableColumnDefinition(property));
        }

        var createTableStatement = $"CREATE TABLE IF NOT EXISTS {tableName} ({string.Join(", ", columns)});";
        return createTableStatement;
    }

    public string CreateTableColumnDefinition(PropertyInfo property)
    {
        var columnName = property.Name;
        var columnType = _typeMappingDefinition[property.PropertyType];
        var columnDefinition = $"{columnName} {columnType}";

        if (property.Name == nameof(IKeyed.Id))
        {
            columnDefinition += " PRIMARY KEY";
        }

        return columnDefinition;
    }
}