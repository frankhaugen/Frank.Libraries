using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.DataProcessing.Workflows;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddActivity<T>(this IServiceCollection services) where T : class, IActivity
    {
        services.AddTransient<IActivity, T>();
        return services;
    }

    public static IServiceCollection AddWorkflowDependencies(this IServiceCollection services)
    {
        services.AddLogging();
        services.AddSingleton<IWorkflowRunner, WorkflowRunner>();
        return services;
    }

    public static IServiceCollection AddWorkflow<T>(this IServiceCollection services) where T : class, IWorkflow
    {
        services.AddTransient<IWorkflow, T>();
        return services;
    }
}