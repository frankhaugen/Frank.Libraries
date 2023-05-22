using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.Http;

public abstract class HttpLoggerProviderBase : ILoggerProvider
{
    public void Dispose() => GC.SuppressFinalize(this);

    public abstract ILogger CreateLogger(string categoryName);
}