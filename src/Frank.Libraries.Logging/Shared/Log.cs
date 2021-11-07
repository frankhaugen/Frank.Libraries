using System;

namespace Frank.Libraries.Logging.Shared
{
    public class Log
    {
        public long Id { get; set; }
        public string? Level { get; set; }
        public int? EventId { get; set; }
        public string ApplicationName { get; set; } = null!;
        public string? EventName { get; set; }
        public string Type { get; set; } = null!;
        public string? Name { get; set; }
        public string? Message { get; set; }
        public string? Exception { get; set; }
        public DateTime Timestamp { get; set; }
    }
}