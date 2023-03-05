namespace Frank.Libraries.Csv;

public class CsvOptions
{
    public string? Folder { get; set; } = "Data";
    public bool HasHeaders { get; set; }
    public string? Delimiter { get; set; } = ";";
}