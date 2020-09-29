using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;

namespace Frank.Libraries.Logging
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly ConcurrentDictionary<string, FileLogger> _loggers = new ConcurrentDictionary<string, FileLogger>();
        private readonly FileLoggerConfiguration _configuration;

        public FileLoggerProvider(FileLoggerConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, name => new FileLogger(name, _configuration));
        }
    }
}
