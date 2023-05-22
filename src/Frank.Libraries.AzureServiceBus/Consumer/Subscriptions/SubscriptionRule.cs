using Azure.Messaging.ServiceBus.Administration;

namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public class SubscriptionRule
{
    /// <summary>
    /// The name of the rule, which is unique within the topic.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The filter expression used to match messages.
    /// </summary>
    public RuleFilter Filter { get; set; }
}