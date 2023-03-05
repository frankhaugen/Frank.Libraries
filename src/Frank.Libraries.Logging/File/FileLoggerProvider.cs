using System.Collections.Concurrent;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.File;

public sealed class FileLoggerProvider : ILoggerProvider
{
    private readonly FileLoggerConfiguration _configuration;
    private readonly ConcurrentDictionary<string, FileLogger> _loggers = new();

    public FileLoggerProvider(FileLoggerConfiguration configuration) => _configuration = configuration;

    public ILogger CreateLogger(string categoryName) => _loggers.GetOrAdd(categoryName, name => new FileLogger(name, _configuration));

    public void Dispose()
    {
    }
}