using System.IO;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging
{
    public class FileLoggerConfiguration
    {
        public FileLoggerConfiguration(string filename = "log", string extension = "txt", string directory = "c:/logs", LogLevel logLevel = LogLevel.Warning, string delimiter = "\t", bool logLocalTime = false)
        {
            Filename = filename;
            Directory = directory;
            Extension = extension;
            LogLevel = logLevel;
            Delimiter = delimiter;
            LogLocalTime = logLocalTime;
        }

        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public string Filename { get; set; }
        public string Directory { get; set; }
        public string Extension { get; set; }
        public string Delimiter { get; set; }
        public bool LogLocalTime { get; set; }

        public string GetPath() => Path.Combine(Directory, Filename + "." + Extension);
    }
}
