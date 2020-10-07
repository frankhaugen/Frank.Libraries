using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.FileLogging
{
    public class Logger
    {
        private readonly FileLoggerConfiguration _options;

        public Logger(FileLoggerConfiguration? options = default)
        {
            options ??= new FileLoggerConfiguration();
            _options = options;
            Setup();
        }

        private void Setup()
        {
            if (!Directory.Exists(_options.Directory))
                Directory.CreateDirectory(_options.Directory);
            if (!File.Exists(_options.GetPath()))
                File.Create(_options.GetPath());
        }

        public void LogDebug(string message, [CallerFilePath] string className = "", [CallerMemberName] string memberName = "")
        {
            var logLevel = LogLevel.Debug;
            if (!IsAboveLogLevel(logLevel)) return;
            var caller = string.Join('.', Path.GetFileNameWithoutExtension(className), memberName);
            var log = ConstructLog(message, caller, logLevel);
            Log(log);
        }

        public void LogInformation(string message, [CallerFilePath] string className = "", [CallerMemberName] string memberName = "")
        {
            var logLevel = LogLevel.Information;
            if (!IsAboveLogLevel(logLevel)) return;
            var caller = string.Join('.', Path.GetFileNameWithoutExtension(className), memberName);
            var log = ConstructLog(message, caller, logLevel);
            Log(log);
        }

        public void LogWarning(string message, [CallerFilePath] string className = "", [CallerMemberName] string memberName = "")
        {
            var logLevel = LogLevel.Warning;
            if (!IsAboveLogLevel(logLevel)) return;
            var caller = string.Join('.', Path.GetFileNameWithoutExtension(className), memberName);
            var log = ConstructLog(message, caller, logLevel);
            Log(log);
        }

        public void LogError(string message, [CallerFilePath] string className = "", [CallerMemberName] string memberName = "")
        {
            var logLevel = LogLevel.Error;
            if (!IsAboveLogLevel(logLevel)) return;
            var caller = string.Join('.', Path.GetFileNameWithoutExtension(className), memberName);
            var log = ConstructLog(message, caller, logLevel);
            Log(log);
        }

        public void LogCritical(string message, [CallerFilePath] string className = "", [CallerMemberName] string memberName = "")
        {
            var logLevel = LogLevel.Critical;
            if (!IsAboveLogLevel(logLevel)) return;
            var caller = string.Join('.', Path.GetFileNameWithoutExtension(className), memberName);
            var log = ConstructLog(message, caller, logLevel);
            Log(log);
        }

        private Log ConstructLog(string message, string? assemblyName, LogLevel loggingLevel) => new Log() { LogLevel = loggingLevel, CallingAssemblyName = assemblyName, Message = message, DateTime = DateTime.UtcNow };

        private string GetLogEntry(Log log) => $"{log.LogLevel}{_options.Delimiter}{log.DateTime}{_options.Delimiter}{log.Message}{_options.Delimiter}{log.CallingAssemblyName}";

        private void Log(Log log)
        {
            var entry = GetLogEntry(log);
            LogFileWriter.WriteString(entry, _options.GetPath());
        }

        private bool IsAboveLogLevel(LogLevel logLevel) => (int)logLevel >= (int)_options.LogLevel;
    }
}
