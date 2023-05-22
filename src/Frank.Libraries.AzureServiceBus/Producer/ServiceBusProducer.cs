using Azure.Messaging.ServiceBus;
using Frank.Libraries.AzureServiceBus.Common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureServiceBus.Producer;

public class ServiceBusProducer : IServiceBusProducer
{
    private readonly IOptions<ServiceBusConfiguration> _options;
    private readonly ILargeMessageProducerHandler _largeMessageHandler;
    private readonly ILogger<ServiceBusProducer> _logger;

    public ServiceBusProducer(IOptions<ServiceBusConfiguration> options, ILargeMessageProducerHandler largeMessageHandler, ILogger<ServiceBusProducer> logger)
    {
        _options = options;
        _largeMessageHandler = largeMessageHandler;
        _logger = logger;
    }

    public async Task<bool> SendMessageAsync(Message message, CancellationToken cancellationToken)
    {
        if (message.Data.Length > _options.Value.LargeMessageThreshold)
        {
            if (!await _largeMessageHandler.HandleLargeMessageAsync(message, cancellationToken))
            {
                _logger.LogError("Failed to send large message");
                return false;
            }

            message.Properties.Add(Constants.MessageProperties.LargeMessage, true);
        }

        var serviceBusMessage = new ServiceBusMessage(message.Data)
        {
            CorrelationId = message.CorrelationId.ToString(),
            MessageId = message.Id.ToString(),
            Subject = message.Subject,
            ContentType = "application/json"
        };

        foreach (var (key, value) in message.Properties)
            serviceBusMessage.ApplicationProperties.Add(key, value);

        try
        {
            var client = new ServiceBusClient(_options.Value.ConnectionString);
            var sender = client.CreateSender(_options.Value.TopicName);
            await sender.SendMessageAsync(serviceBusMessage, cancellationToken);
            _logger.LogDebug("Message {MessageId} sent to {TopicName} with subject {Subject}", message.Id, _options.Value.TopicName, message.Subject);
            return true;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Failed to send message {MessageId} to {TopicName} with subject {Subject}", message.Id, _options.Value.TopicName, message.Subject);
            return false;
        }
    }
}