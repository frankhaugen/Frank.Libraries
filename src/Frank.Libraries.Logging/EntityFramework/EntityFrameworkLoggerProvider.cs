using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.Logging.EntityFramework
{
    public class EntityFrameworkLoggerProvider<TContext> : EntityFrameworkLoggerProviderBase
        where TContext : DbContext
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly EntityFrameworkLoggerConfiguration _configuration;

        public EntityFrameworkLoggerProvider(IServiceProvider serviceProvider, EntityFrameworkLoggerConfiguration configuration)
        {
            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }

        public override ILogger CreateLogger(string categoryName) => new EntityFrameworkLogger<TContext>(_serviceProvider, _configuration, categoryName);
    }
}