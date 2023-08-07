namespace Frank.Libraries.AzureServiceBus.Common;

public class ServiceBusConfiguration
{
    public string ConnectionString { get; set; }
    public string TopicName { get; set; }
    public long LargeMessageThreshold { get; set; } = 1024 * 1024 * 4; // 4 MB
}