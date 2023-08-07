using System.Collections;

namespace Frank.Libraries.DataProcessing.Tables;

public class DataTable : IEnumerable<Row>
{
    private readonly List<Row> _rows = new();

    public DataTable(string name, Headers header)
    {
        Name = name;
        Header = header;
    }

    public Headers Header { get; }

    public Row this[int index] => _rows[index];

    public string Name { get; }

    public IEnumerator<Row> GetEnumerator() => _rows.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(Row row) => _rows.Add(row);

    public void AddRange(IEnumerable<Row> rows) => _rows.AddRange(rows);
}