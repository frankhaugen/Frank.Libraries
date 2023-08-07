namespace Frank.Libraries.Logging.Shared;

public class Log
{
    public long Id { get; set; }
    public string Level { get; set; }
    public int EventId { get; set; }
    public string ApplicationName { get; set; }
    public string? EventName { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
    public string? Stacktrace { get; set; }
    public string DotnetVersion { get; set; }
    public string MachineName { get; set; }
    public string OperatingSystem { get; set; }
    public DateTime Timestamp { get; set; }
}