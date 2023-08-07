using Frank.Libraries.AzureServiceBus.Common;
using Frank.Libraries.AzureServiceBus.Consumer;
using Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Frank.Libraries.AzureServiceBus.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServiceBusMessageHandler<TMessageHandler>(this IServiceCollection services, IConfiguration configuration)
        where TMessageHandler : class, IServiceBusMessageHandler
    {
        services.Configure<ServiceBusConfiguration>(configuration.GetSection(nameof(ServiceBusConfiguration)));
        services.AddServiceBusRuleProvider<CatchAllSubscriptionRuleProvider>();
        services.AddSingleton<IServiceBusMessageHandler, TMessageHandler>();
        services.AddSingleton<IServiceBusSubscriptionManager, ServiceBusSubscriptionManager>();
        services.AddHostedService<ServiceBusConsumer<TMessageHandler>>();
        return services;
    }

    public static IServiceCollection AddServiceBusRuleProvider<TSubscriptionRuleProvider>(this IServiceCollection services)
        where TSubscriptionRuleProvider : class, ISubscriptionRuleProvider
    {
        return services.AddTransient<ISubscriptionRuleProvider, TSubscriptionRuleProvider>();
    }
}