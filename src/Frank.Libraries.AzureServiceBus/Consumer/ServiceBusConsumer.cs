using Azure.Messaging.ServiceBus;
using Frank.Libraries.AzureServiceBus.Common;
using Frank.Libraries.AzureServiceBus.Consumer.Subscriptions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Frank.Libraries.AzureServiceBus.Consumer;

public class ServiceBusConsumer<THandler> : BackgroundService where THandler : IServiceBusMessageHandler
{
    private readonly ILogger<ServiceBusConsumer<THandler>> _logger;
    private readonly IServiceBusMessageHandler _messageHandler;
    private readonly IOptions<ServiceBusConfiguration> _options;
    private readonly IServiceBusSubscriptionManager _subscriptionManager;

    private readonly ServiceBusClient _client;

    public ServiceBusConsumer(ILogger<ServiceBusConsumer<THandler>> logger, IServiceBusMessageHandler messageHandler, IOptions<ServiceBusConfiguration> options, IServiceBusSubscriptionManager subscriptionManager)
    {
        _logger = logger;
        _messageHandler = messageHandler;
        _options = options;
        _subscriptionManager = subscriptionManager;
        _client = new ServiceBusClient(_options.Value.ConnectionString);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (_messageHandler.Options.ConsumeMessages)
        {
            await _subscriptionManager.CreateSubscriptionIfNotExistAsync(_messageHandler.Options.SubscriptionName);

            var processor = _client.CreateProcessor(_options.Value.TopicName, _messageHandler.Options.SubscriptionName, new ServiceBusProcessorOptions
            {
                AutoCompleteMessages = _messageHandler.Options.AutoComplete,
                MaxConcurrentCalls = _messageHandler.Options.MaxConcurrentCalls,
                Identifier = _messageHandler.GetType()
                                            .Name
            });

            processor.ProcessMessageAsync += OnProcessorOnProcessMessageAsync;
            processor.ProcessErrorAsync += OnProcessorOnProcessErrorAsync;
        }
    }

    private Task OnProcessorOnProcessErrorAsync(ProcessErrorEventArgs arg)
    {
        _logger.LogCritical(arg.Exception, "Error while processing message from subscription {SubscriptionName}; Errors shouldn't be unhandled like this", _messageHandler.Options.SubscriptionName);
        return Task.CompletedTask;
    }

    private async Task OnProcessorOnProcessMessageAsync(ProcessMessageEventArgs args)
    {
        MessageAction action = MessageAction.Complete;

        try
        {
            var message = ParseBody<Message>(args.Message);
            action = await _messageHandler.HandleMessageAsync(message, args.CancellationToken);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Error while handling message {MessageId} from subscription {SubscriptionName}", args.Message.MessageId, _messageHandler.Options.SubscriptionName);
            action = MessageAction.DeadLetter;
        }
        finally
        {
            switch (action)
            {
                case MessageAction.Complete:
                    await args.CompleteMessageAsync(args.Message);
                    _logger.LogDebug("Message {MessageId} from subscription {SubscriptionName} completed", args.Message.MessageId, _messageHandler.Options.SubscriptionName);
                    break;
                case MessageAction.Abandon:
                    await args.AbandonMessageAsync(args.Message);
                    _logger.LogDebug("Message {MessageId} from subscription {SubscriptionName} abandoned", args.Message.MessageId, _messageHandler.Options.SubscriptionName);
                    break;
                case MessageAction.DeadLetter:
                    await args.DeadLetterMessageAsync(args.Message);
                    _logger.LogDebug("Message {MessageId} from subscription {SubscriptionName} dead lettered", args.Message.MessageId, _messageHandler.Options.SubscriptionName);
                    break;
                case MessageAction.Defer:
                default:
                    await args.DeferMessageAsync(args.Message);
                    _logger.LogDebug("Message {MessageId} from subscription {SubscriptionName} deferred", args.Message.MessageId, _messageHandler.Options.SubscriptionName);
                    break;
            }
        }
    }

    private static T ParseBody<T>(ServiceBusReceivedMessage message)
    {
        var body = message.Body.ToString();
        return System.Text.Json.JsonSerializer.Deserialize<T>(body);
    }
}