using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging
{
    public class FileLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public string Path { get; set; } = "c:/logs";
    }
}
