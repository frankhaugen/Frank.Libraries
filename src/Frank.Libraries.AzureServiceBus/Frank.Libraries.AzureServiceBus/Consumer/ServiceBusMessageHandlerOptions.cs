namespace Frank.Libraries.AzureServiceBus.Consumer;

public class ServiceBusMessageHandlerOptions
{
    public string SubscriptionName { get; set; }
    public bool ConsumeMessages { get; set; } = true;

    public bool AutoComplete { get; set; } = true;

    public int MaxConcurrentCalls { get; set; } = 1;
}