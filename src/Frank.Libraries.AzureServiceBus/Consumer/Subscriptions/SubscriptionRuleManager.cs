using Azure.Messaging.ServiceBus.Administration;
using Frank.Libraries.AzureServiceBus.Common;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public class SubscriptionRuleManager : ISubscriptionRuleManager
{
    private readonly IOptions<ServiceBusConfiguration> _options;
    private readonly IEnumerable<ISubscriptionRuleProvider> _correlationFilterProviders;

    public SubscriptionRuleManager(IOptions<ServiceBusConfiguration> options, IEnumerable<ISubscriptionRuleProvider> correlationFilterProviders)
    {
        _options = options;
        _correlationFilterProviders = correlationFilterProviders;
    }

    public async Task UpdateRulesAsync(string subscriptionName)
    {
        var client = new ServiceBusAdministrationClient(_options.Value.ConnectionString);
        var existingRulesPageable = client.GetRulesAsync(_options.Value.TopicName, subscriptionName);
        await foreach (var existingRule in existingRulesPageable)
        {
            await client.DeleteRuleAsync(_options.Value.TopicName, subscriptionName, existingRule.Name);
        }

        var rules = _correlationFilterProviders.Select(provider => provider.GetRule())
                                               .ToList();

        foreach (var rule in rules)
        {
            await client.CreateRuleAsync(_options.Value.TopicName, subscriptionName, new CreateRuleOptions(rule.Name, rule.Filter));
        }
    }
}