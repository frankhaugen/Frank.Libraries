using Frank.Libraries.AzureServiceBus.Common;

namespace Frank.Libraries.AzureServiceBus.Producer;

public interface ILargeMessageProducerHandler
{
    /// <summary>
    /// Handles large messages, sending them to a blob storage, ftp server, etc. expecting the ID of the large message to be the identifier of the large message body in the storage.
    /// </summary>
    /// <param name="message">Will be modified if successful</param>
    /// <param name="cancellationToken"></param>
    /// <returns>If the alternative body sending strategy succeeded</returns>
    Task<bool> HandleLargeMessageAsync(Message message, CancellationToken cancellationToken);
}