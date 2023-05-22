namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.PingReceived" /> events.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcPingReceivedEventArgs : IrcPingOrPongReceivedEventArgs
{
    public IrcPingReceivedEventArgs(string server)
        : base(server) =>
        SendPong = true;

    /// <summary>
    ///     Gets or sets if we should send a Pong back
    /// </summary>
    /// <value>A value indicating sending a Pong.</value>
    public bool SendPong { get; set; }
}