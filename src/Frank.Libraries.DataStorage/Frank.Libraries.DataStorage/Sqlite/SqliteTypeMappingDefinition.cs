namespace Frank.Libraries.DataStorage.Sqlite;

internal class SqliteTypeMappingDefinition
{
    private readonly Dictionary<string, IEnumerable<Type>> _typeMappings;

    public SqliteTypeMappingDefinition() =>
        _typeMappings = new Dictionary<string, IEnumerable<Type>>
        {
            { "INTEGER", new IntegerTypes() },
            { "TEXT", new TextTypes() },
            { "BLOB", new BlobTypes() },
            { "REAL", new RealTypes() },
            { "NUMERIC", new NumericTypes() }
        };

    public IEnumerable<Type> this[string affinity]
    {
        get
        {
            if (_typeMappings.TryGetValue(affinity, out var types))
            {
                return types;
            }

            throw new KeyNotFoundException($"No types found for SQLite affinity '{affinity}'.");
        }
    }

    public string this[Type type]
    {
        get
        {
            foreach (var mapping in _typeMappings)
            {
                if (mapping.Value.Contains(type))
                {
                    return mapping.Key;
                }
            }

            throw new KeyNotFoundException($"No SQLite affinity found for type '{type}'.");
        }
    }
}