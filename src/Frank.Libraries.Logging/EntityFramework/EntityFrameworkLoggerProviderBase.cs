using System;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.EntityFramework;

public abstract class EntityFrameworkLoggerProviderBase : ILoggerProvider
{
    public void Dispose() => GC.SuppressFinalize(this);

    public abstract ILogger CreateLogger(string categoryName);
}