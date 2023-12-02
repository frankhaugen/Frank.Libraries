using System.Data;
using Microsoft.Extensions.Options;
using Namotion.Reflection;

namespace Frank.Libraries.DataStorage.Xml;

public class XmlDataContext
{
    private readonly DataSet _dataSet;
    private readonly IOptions<XmlConnection> _options;
    private readonly XmlFile _file;

    public XmlDataContext(IOptions<XmlConnection> options)
    {
        _options = options;
        _file = new XmlFile(new FileInfo(_options.Value.XmlDataFile));
        _dataSet = _file.ReadXml();
    }

    public DataTable GetTable<T>() where T : class, IKeyed, new() => GetOrCreateTable<T>();

    private DataTable GetOrCreateTable<T>() where T : class, IKeyed, new()
    {
        var tableName = typeof(T).GetDisplayName();
        var table = _dataSet.Tables[tableName];
        if (table == null)
        {
            table = CreateDataTable<T>(tableName);
        }

        return table;
    }

    private DataTable CreateDataTable<T>(string tableName) where T : class, IKeyed, new()
    {
        var table = new DataTable(tableName);

        var properties = typeof(T).GetProperties();
        foreach (var property in properties)
        {
            table.Columns.Add(property.Name, property.PropertyType);
        }

        table.PrimaryKey = new[] { table.Columns["Id"] }!;

        _dataSet.Tables.Add(table);
        return table;
    }

    public void SaveChanges() => _file.WriteXml(_dataSet);
}