using System;
using System.Text;
using Frank.Libraries.Logging.Shared;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Sql
{
    internal static class SqlQueryConstructor
    {
        public static string ConstructQuery<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter, string name) =>
            new StringBuilder()
                .AppendLine($"INSERT INTO {nameof(Log)}s({nameof(Log.Level)}, {nameof(Log.ApplicationName)}, {nameof(Log.Message)}, {nameof(Log.DotnetVersion)}, {nameof(Log.EventId)}, {nameof(Log.EventName)}, {nameof(Log.Stacktrace)}, {nameof(Log.Timestamp)}, {nameof(Log.Name)})")
                .AppendLine($"VALUES('{logLevel}', '{AppDomain.CurrentDomain.FriendlyName}', '{formatter(state, exception)}', '{Environment.Version}', '{eventId.Id}', '{eventId.Name}', '{exception.StackTrace}', '{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss:fff}', '{name}')")
                .ToString();
    }
}