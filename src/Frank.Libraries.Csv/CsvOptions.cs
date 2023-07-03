namespace Frank.Libraries.Csv;

/// <summary>
///     Represents the configuration options for the CsvParser.
/// </summary>
public class CsvOptions
{
    /// <summary>
    ///     Gets or sets a value indicating whether the CSV content has a header.
    /// </summary>
    public bool HasHeader { get; set; }

    /// <summary>
    ///     Gets or sets the delimiter character used in the CSV content.
    /// </summary>
    /// <value>The default is ";".</value>
    public string Delimiter { get; set; } = ";";

    /// <summary>
    ///     Gets or sets the start quote character used in the CSV content.
    /// </summary>
    /// <value>The default is "\"".</value>
    public string StartQuote { get; set; } = "\"";

    /// <summary>
    ///     Gets or sets the stop quote character used in the CSV content.
    /// </summary>
    /// <value>The default is "\"".</value>
    public string StopQuote { get; set; } = "\"";

    /// <summary>
    ///     Gets or sets the number of columns in the CSV content.
    /// </summary>
    /// <value>The default is 2.</value>
    public int ColumnCount { get; set; } = 2;

    /// <summary>
    ///     Gets or sets the new line character used in the CSV content.
    /// </summary>
    /// <value>The default is <see cref="Environment.NewLine" />.</value>
    public string NewLine { get; set; } = Environment.NewLine;
}