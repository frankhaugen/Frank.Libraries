using System.Text;

namespace Frank.Libraries.Csv;

public class CsvParser : ICsvParser
{
    private readonly StringBuilder _currentField;
    private readonly CsvOptions _options;

    public CsvParser(CsvOptions options)
    {
        _options = options ?? throw new ArgumentNullException(nameof(options));
        _currentField = new StringBuilder();
    }

    public ICsvDocument Parse(string name, ReadOnlySpan<char> data)
    {
        var dataLookup = new Dictionary<uint, string[]>();
        uint rowIndex = 0;
        var fields = new string[_options.ColumnCount];
        var fieldIndex = 0;
        var insideQuotes = false;
        var delimiterLength = _options.Delimiter.Length;

        for (var i = 0; i < data.Length; i++)
        {
            var currentChar = data[i];

            insideQuotes = HandleQuoteCharacter(currentChar, insideQuotes);

            if (IsDelimiter(data, i, delimiterLength) && !insideQuotes)
            {
                AddField(fields, fieldIndex);
                fieldIndex++;

                if (fieldIndex == _options.ColumnCount)
                {
                    AddRow(dataLookup, rowIndex, fields);
                    fields = CreateEmptyFieldsArray();
                    fieldIndex = 0;
                    rowIndex++;
                }

                i += delimiterLength - 1; // Skip the delimiter
            }
            else if (IsNewLine(data, i) && !insideQuotes)
            {
                AddField(fields, fieldIndex);
                fieldIndex++;

                if (fieldIndex == _options.ColumnCount)
                {
                    AddRow(dataLookup, rowIndex, fields);
                    fields = CreateEmptyFieldsArray();
                    fieldIndex = 0;
                    rowIndex++;
                }

                i += Environment.NewLine.Length - 1; // Skip the newline
            }
            else
            {
                _currentField.Append(currentChar);
            }
        }

        AddField(fields, fieldIndex);
        if (fieldIndex > 0)
        {
            AddRow(dataLookup, rowIndex, fields);
        }

        return new CsvDocument(_options, name, dataLookup);
    }

    private bool IsQuote(char character) => character == _options.StartQuote[0] || character == _options.StopQuote[0];

    private bool IsDelimiter(ReadOnlySpan<char> data, int currentIndex, int delimiterLength) => data.Slice(currentIndex, delimiterLength)
                                                                                                    .SequenceEqual(_options.Delimiter);

    private bool IsNewLine(ReadOnlySpan<char> data, int currentIndex)
    {
        // Guard against currentIndex being outside the allowable range of indices for data.
        if (currentIndex < 0 || currentIndex >= data.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(currentIndex), "Current index is outside the allowable range of indices for the given data.");
        }

        // Guard against the slice operation extending beyond the end of the span.
        if (currentIndex + _options.NewLine.Length > data.Length)
        {
            return false; // Not enough characters remaining for a new line.
        }

        return data.Slice(currentIndex, _options.NewLine.Length)
                   .SequenceEqual(_options.NewLine.AsSpan());
    }

    private bool HandleQuoteCharacter(char currentChar, bool insideQuotes) => IsQuote(currentChar)
        ? !insideQuotes
        : insideQuotes;

    private void AddField(string[] fields, int fieldIndex)
    {
        fields[fieldIndex] = _currentField.ToString()
                                          .Trim();
        _currentField.Clear();
    }

    private void AddRow(Dictionary<uint, string[]> dataLookup, uint rowIndex, string[] fields) => dataLookup[rowIndex] = fields;

    private string[] CreateEmptyFieldsArray() => new string[_options.ColumnCount];
}