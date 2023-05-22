namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.PingReceived" /> and <see cref="IrcClient.PongReceived" /> events.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcPingOrPongReceivedEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcPingOrPongReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="server">The name of the server that is the source of the ping or pong.</param>
    public IrcPingOrPongReceivedEventArgs(string server)
    {
        if (server == null)
        {
            throw new ArgumentNullException("server");
        }

        Server = server;
    }

    /// <summary>
    ///     Gets the name of the server that is the source of the ping or pong.
    /// </summary>
    /// <value>The name of the server.</value>
    public string Server { get; }
}