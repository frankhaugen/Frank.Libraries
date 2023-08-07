using System.Collections;
using System.Diagnostics;

namespace Frank.Libraries.Csv;

[DebuggerDisplay("Key = {Key}, Values = {ToString()}")]
public class CsvRow : IGrouping<uint, string>
{
    private readonly IEnumerable<string> _row;

    public CsvRow(uint key, IEnumerable<string> row)
    {
        Key = key;
        _row = row;
    }

    public uint Key { get; }
    public IEnumerator<string> GetEnumerator() => _row.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public override string ToString() => string.Join("\t", _row);
}