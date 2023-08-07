using Azure.Messaging.ServiceBus.Administration;

namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public class CatchAllSubscriptionRuleProvider : ISubscriptionRuleProvider
{
    public SubscriptionRule GetRule() => new SubscriptionRule
    {
        Name = "CatchAll",
        Filter = new CorrelationRuleFilter()
    };
}