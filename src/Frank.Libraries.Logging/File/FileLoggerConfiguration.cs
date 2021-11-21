using System.IO;
using Frank.Libraries.Logging.Shared;

namespace Frank.Libraries.Logging.File
{
    public class FileLoggerConfiguration : LoggerConfigurationBase
    {
        public string Filename { get; set; }
        public string Directory { get; set; }
        public string Extension { get; set; }
        public string Delimiter { get; set; }
        public bool LogLocalTime { get; set; }

        public string GetPath() => Path.Combine(Directory, Filename + "." + Extension);
    }
}