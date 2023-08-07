using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.DataProcessing.Cloning;

public class BuilderContext : IBuilderContext
{
    public IHostEnvironment Environment { get; }
    public IServiceCollection Services { get; }
    public IConfigurationProvider Configuration { get; }
    public ILoggingBuilder Logging { get; }

    public BuilderContext(IHostEnvironment environment, IServiceCollection services, IConfigurationProvider configuration, ILoggingBuilder logging)
    {
        Environment = environment;
        Services = services;
        Configuration = configuration;
        Logging = logging;
    }
}