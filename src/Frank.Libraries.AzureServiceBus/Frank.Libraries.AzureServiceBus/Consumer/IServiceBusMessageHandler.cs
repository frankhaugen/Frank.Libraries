using Frank.Libraries.AzureServiceBus.Common;

namespace Frank.Libraries.AzureServiceBus.Consumer;

public interface IServiceBusMessageHandler
{
    ServiceBusMessageHandlerOptions Options { get; }

    Task<MessageAction> HandleMessageAsync(Message message, CancellationToken cancellationToken);
}