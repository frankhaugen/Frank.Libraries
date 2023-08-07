using Azure.Messaging.ServiceBus.Administration;
using Frank.Libraries.AzureServiceBus.Common;
using Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureServiceBus.Consumer;

public class ServiceBusSubscriptionManager : IServiceBusSubscriptionManager
{
    private readonly IOptions<ServiceBusConfiguration> _options;
    private readonly ISubscriptionRuleManager _subscriptionRuleManager;

    public ServiceBusSubscriptionManager(IOptions<ServiceBusConfiguration> options, ISubscriptionRuleManager subscriptionRuleManager)
    {
        _options = options;
        _subscriptionRuleManager = subscriptionRuleManager;
    }

    public async Task CreateSubscriptionIfNotExistAsync(string subscriptionName)
    {
        var client = new ServiceBusAdministrationClient(_options.Value.ConnectionString);

        if (!await client.SubscriptionExistsAsync(_options.Value.TopicName, subscriptionName))
        {
            await client.CreateSubscriptionAsync(_options.Value.TopicName, subscriptionName);
        }

        await _subscriptionRuleManager.UpdateRulesAsync(subscriptionName);
    }
}