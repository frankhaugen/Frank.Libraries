namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for the <see cref="CtcpClient.RawMessageSent" /> and
///     <see cref="CtcpClient.RawMessageReceived" /> events.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpRawMessageEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpRawMessageEventArgs" /> class.
    /// </summary>
    /// <param name="message">The message that was sent/received.</param>
    public CtcpRawMessageEventArgs(CtcpClient.CtcpMessage message) => Message = message;

    /// <summary>
    ///     Gets the message that was sent/received by the client.
    /// </summary>
    /// <value>The message that was sent/received by the client.</value>
    public CtcpClient.CtcpMessage Message { get; }
}