using Frank.Libraries.Fiken.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.Fiken.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFiken(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddTransient();


        services.ConfigureOptions<Configuration>();
        return services;

    }
}