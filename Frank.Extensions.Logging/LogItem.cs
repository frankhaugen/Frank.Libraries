using System;

namespace Frank.Extensions.Logging
{
    public class LogItem
    {
        public long Id { get; set; }
        public string LogLevel { get; set; }
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string? Exception { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
    }
}