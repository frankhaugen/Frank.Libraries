using System.Collections;

namespace Frank.Libraries.DataProcessing.Tables;

public class Row : IEnumerable<Cell>
{
    private readonly IReadOnlySet<Cell> _cells;

    public Row(IEnumerable<Cell> cells) => _cells = cells.ToHashSet();

    public Cell this[int index] => _cells.ElementAt(index);

    public IEnumerator<Cell> GetEnumerator() => _cells.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}