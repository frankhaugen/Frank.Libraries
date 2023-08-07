using System.Collections;
using System.Diagnostics;

namespace Frank.Libraries.Csv;

[DebuggerDisplay("{" + nameof(Name) + "}")]
public class CsvDocument : ICsvDocument
{
    private readonly Dictionary<uint, string[]> _data;

    internal CsvDocument(CsvOptions options, string name, Dictionary<uint, string[]> data)
    {
        Options = options;
        Name = name;
        _data = data;
    }

    /// <summary>
    ///     Gets the name of the document.
    /// </summary>
    public string Name { get; }

    public IEnumerable<CsvRow> Rows => _data.Select(d => new CsvRow(d.Key, d.Value));

    /// <summary>
    ///     Gets the options used to parse the document.
    /// </summary>
    public CsvOptions Options { get; }

    /// <summary>
    ///     Returns an enumerator that iterates through the document.
    /// </summary>
    /// <returns>An enumerator that can be used to iterate through the collection.</returns>
    IEnumerator<IGrouping<uint, string>> IEnumerable<IGrouping<uint, string>>.GetEnumerator() => _data.Select(d => new CsvRow(d.Key, d.Value))
                                                                                                      .GetEnumerator();
    /// <summary>
    ///     Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_data).GetEnumerator();

    /// <summary>
    ///     Determines whether the document contains the specified key.
    /// </summary>
    /// <param name="key">The key to locate in the document.</param>
    /// <returns>true if the document contains the specified key; otherwise, false.</returns>
    public bool Contains(uint key) => _data.ContainsKey(key);

    /// <summary>
    ///     Gets the number of groupings contained in the document.
    /// </summary>
    public int Count => _data.Count;

    /// <summary>
    ///     Gets the elements with the specified key.
    /// </summary>
    /// <param name="key">The key of the element to get.</param>
    /// <returns>The elements with the specified key.</returns>
    public IEnumerable<string> this[uint key] => _data.TryGetValue(key, out var value)
        ? value
        : throw new KeyNotFoundException();

    /// <summary>
    ///    Returns a string that represents the document separated by the delimiter and newline.
    /// </summary>
    public override string ToString() => _data.Select(d => d.Value.ConcatWith(Options.Delimiter)).ConcatWith(Options.NewLine);
}