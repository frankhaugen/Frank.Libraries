using System;

namespace Frank.Libraries.Logging
{
    public class LogItem
    {
        public long Id { get; set; }
        public string LogLevel { get; set; } = null!;
        public string ApplicationName { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string EventId { get; set; } = null!;
        public string EventName { get; set; } = null!;
        public string? Exception { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; } = null!;
    }
}