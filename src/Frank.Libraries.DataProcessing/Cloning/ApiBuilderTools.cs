using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Frank.Libraries.DataProcessing.Cloning;

public class ApiBuilderTools
{

}

public class HostEnvironment : IHostEnvironment
{
    public string EnvironmentName { get; set; }
    public string ApplicationName { get; set; }
    public string ContentRootPath { get; set; }
    public IFileProvider ContentRootFileProvider { get; set; }
}

public class ApiHost : IHost
{
    public void Dispose() => throw new NotImplementedException();

    public async Task StartAsync(CancellationToken cancellationToken = new CancellationToken()) => throw new NotImplementedException();

    public async Task StopAsync(CancellationToken cancellationToken = new CancellationToken()) => throw new NotImplementedException();

    public IServiceProvider Services { get; }
}




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





public interface IBuilder
{
    public IServiceProvider ServiceProvider {get;}
}



public interface IBuilderContext
{
    /// <summary>
    /// Provides information about the web hosting environment an application is running.
    /// </summary>
    public IHostEnvironment Environment { get; }

    /// <summary>
    /// A collection of services for the application to compose. This is useful for adding user provided or framework provided services.
    /// </summary>
    public IServiceCollection Services { get; }

    /// <summary>
    /// A collection of configuration providers for the application to compose. This is useful for adding new configuration sources and providers.
    /// </summary>
    public IConfigurationProvider Configuration { get; }

    /// <summary>
    /// A collection of logging providers for the application to compose. This is useful for adding new logging providers.
    /// </summary>
    public ILoggingBuilder Logging { get; }
}
