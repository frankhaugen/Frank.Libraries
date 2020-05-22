using Microsoft.Extensions.Logging;

namespace Frank.Extensions.Logging
{
    public class SqlLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public string ConnectionString { get; set; } = null!;
    }
}