namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public interface ISubscriptionRuleProvider
{
    SubscriptionRule GetRule();
}