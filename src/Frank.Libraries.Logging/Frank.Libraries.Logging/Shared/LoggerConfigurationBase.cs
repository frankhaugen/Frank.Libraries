using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Shared;

public abstract class LoggerConfigurationBase
{
    public LogLevel LogLevel { get; set; } = LogLevel.Information;
}