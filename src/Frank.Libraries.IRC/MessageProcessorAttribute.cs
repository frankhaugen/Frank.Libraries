namespace Frank.Libraries.IRC;

// Indicates that method processes message for some protocol.
internal class MessageProcessorAttribute : Attribute
{
    public MessageProcessorAttribute(string commandName) => CommandName = commandName;

    public string CommandName { get; }
}