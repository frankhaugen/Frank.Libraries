namespace Frank.Libraries.Csv;

public interface ICsvDocument : ILookup<uint, string>
{
    string Name { get; }

    IEnumerable<CsvRow> Rows { get; }

    CsvOptions Options { get; }
}