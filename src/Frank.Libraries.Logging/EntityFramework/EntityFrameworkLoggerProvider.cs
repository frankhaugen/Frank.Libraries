using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.Logging.EntityFramework;

public class EntityFrameworkLoggerProvider<TContext> : EntityFrameworkLoggerProviderBase
    where TContext : DbContext
{
    private readonly EntityFrameworkLoggerConfiguration _configuration;
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkLoggerProvider(IServiceProvider serviceProvider, IOptions<EntityFrameworkLoggerConfiguration> options)
    {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        _configuration = options.Value;
    }

    public override ILogger CreateLogger(string categoryName) => new EntityFrameworkLogger<TContext>(_serviceProvider, _configuration, categoryName);
}