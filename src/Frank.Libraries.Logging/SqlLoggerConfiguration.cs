using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging
{
    public class SqlLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public string ConnectionString { get; set; } = null!;
    }
}