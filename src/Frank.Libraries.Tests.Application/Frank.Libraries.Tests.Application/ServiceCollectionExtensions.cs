namespace Frank.Libraries.Tests.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddComponent<THostedService>(this IServiceCollection services, Action<IServiceCollection> registerServices, bool shouldRun)
        where THostedService : class, IHostedService
    {
        if (!shouldRun) return services;

        // Register the services.
        registerServices(services);

        // Register the IHostedService, if shouldRun is true.
        services.AddHostedService<THostedService>();

        return services;
    }
}