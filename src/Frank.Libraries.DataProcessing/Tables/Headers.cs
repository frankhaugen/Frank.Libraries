using System.Collections;

namespace Frank.Libraries.DataProcessing.Tables;

public class Headers : IEnumerable<Column>
{
    private readonly IReadOnlySet<Column> _columns;

    public Headers(IEnumerable<Column> columns) => _columns = columns.ToHashSet();

    public Column this[int index] => _columns.ElementAt(index);

    public IEnumerator<Column> GetEnumerator() => _columns.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}