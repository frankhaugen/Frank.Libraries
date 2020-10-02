namespace Frank.Libraries.Csv
{
    public class CsvConfiguration
    {
        public string? Folder { get; set; } = "Data";
        public bool HasHeaders { get; set; }
        public string? Delimiter { get; set; } = ";";
    }
}
