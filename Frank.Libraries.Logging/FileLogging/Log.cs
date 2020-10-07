using System;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.FileLogging
{
    public class Log
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; }
        public string? CallingAssemblyName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
