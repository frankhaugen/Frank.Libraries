using System;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Exceptions
{
    public class LoggerException<TLogger> : Exception
    where TLogger : ILogger
    {
        private readonly string _loggerName;

        public LoggerException(string message) : base(message)
        {
            _loggerName = typeof(TLogger).Name;
        }

        public string GetLoggerName() => _loggerName;
        public StackTrace GetStackTrace() => new StackTrace(this);
    }
}
