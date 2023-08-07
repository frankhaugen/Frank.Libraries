namespace Frank.Libraries.AzureServiceBus.Common;

public class Message
{
    public Guid Id { get; } = Guid.NewGuid();
    public Guid CorrelationId { get; set; } = Guid.NewGuid();
    public required string Subject { get; set; }
    public required byte[] Data { get; set; }
    public Dictionary<string, object> Properties { get; } = new();
}