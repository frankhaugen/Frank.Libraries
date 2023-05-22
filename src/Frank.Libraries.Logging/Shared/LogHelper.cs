using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Shared;

public static class LogHelper
{
    public static Log GetLog<TState>(string name, LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) =>
        new()
        {
            Timestamp = DateTime.UtcNow,
            EventId = eventId.Id,
            EventName = eventId.Name,
            Level = logLevel.ToString(),
            Message = formatter(state, exception),
            Name = name,
            ApplicationName = AppDomain.CurrentDomain.FriendlyName,
            Stacktrace = exception?.StackTrace,
            DotnetVersion = Environment.Version.ToString(),
            MachineName = Environment.MachineName,
            OperatingSystem = Environment.OSVersion.ToString()
        };
}