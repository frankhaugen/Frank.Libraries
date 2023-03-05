using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Management;

namespace Frank.Libraries.AzureServiceBus;

public class ServiceBusTopicClient
{
    private readonly string _connectionString;
    private readonly int _lockDuration;
    private readonly int _messageLifetime;
    private readonly string _subscriptionName;
    private readonly string _topicName;
    private readonly ManagementClient _managementClient;
    private ISubscriptionClient _subscriptionClient;
    private readonly TopicClient _topicClient;

    public ServiceBusTopicClient(string connectionString, string topicName, string subscriptionName, int lockDuration = 5, int messageLifetime = 24)
    {
        _connectionString = connectionString;
        _topicName = topicName;
        _subscriptionName = subscriptionName;
        _lockDuration = lockDuration;
        _messageLifetime = messageLifetime;
        _topicClient = new TopicClient(_connectionString, _topicName);
        _managementClient = new ManagementClient(_connectionString);
        _subscriptionClient = new SubscriptionClient(_connectionString, _topicName, _subscriptionName);
    }

    public async Task<bool> SendMessage<T>(T body, string label, string? messageId = null)
    {
        try
        {
            await _topicClient.SendAsync(new Message
            {
                MessageId = messageId
                            ?? Guid.NewGuid()
                                   .ToString(),
                Label = label,
                Body = JsonSerializer.SerializeToUtf8Bytes(body, new JsonSerializerOptions
                {
                    NumberHandling = JsonNumberHandling.WriteAsString,
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                }),
                ContentType = "application/json"
            });
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> CreateSubscriptionIfNotExist()
    {
        if (await _managementClient.SubscriptionExistsAsync(_topicName, _subscriptionName))
        {
            return true;
        }

        try
        {
            await _managementClient.CreateSubscriptionAsync(new SubscriptionDescription(_topicName, _subscriptionName)
            {
                DefaultMessageTimeToLive = TimeSpan.FromHours(_messageLifetime),
                LockDuration = TimeSpan.FromMinutes(_lockDuration)
            });
            await _managementClient.CreateRuleAsync(_topicName, _subscriptionName, new RuleDescription(_subscriptionName, new TrueFilter { Parameters = { { "Label", _subscriptionName } } }));
            return true;
        }
        catch
        {
            return false;
        }
    }
}