namespace Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;

public interface IServiceBusSubscriptionManager
{
    Task CreateSubscriptionIfNotExistAsync(string subscriptionName);
}