namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.RawMessageSent" /> and
///     <see cref="IrcClient.RawMessageReceived" /> events.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcRawMessageEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcRawMessageEventArgs" /> class.
    /// </summary>
    /// <param name="message">The message that was sent/received.</param>
    /// <param name="rawContent">The raw content of the message.</param>
    public IrcRawMessageEventArgs(IrcClient.IrcMessage message, string rawContent)
    {
        Message = message;
        RawContent = rawContent;
    }

    /// <summary>
    ///     Gets the message that was sent/received by the client.
    /// </summary>
    /// <value>The message that was sent/received by the client.</value>
    public IrcClient.IrcMessage Message { get; }

    /// <summary>
    ///     Gets the raw content of the message.
    /// </summary>
    /// <value>The raw content of the message.</value>
    public string RawContent { get; }
}