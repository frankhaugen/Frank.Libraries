namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public interface ISubscriptionRuleManager
{
    Task UpdateRulesAsync(string subscriptionName);
}