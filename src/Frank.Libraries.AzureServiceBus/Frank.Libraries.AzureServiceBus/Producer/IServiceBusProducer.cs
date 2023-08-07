using Frank.Libraries.AzureServiceBus.Common;

namespace Frank.Libraries.AzureServiceBus.Producer;

public interface IServiceBusProducer
{
    /// <summary>
    /// Sends a message to the service bus topic
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>If the message was sent successfully</returns>
    Task<bool> SendMessageAsync(Message message, CancellationToken cancellationToken);
}