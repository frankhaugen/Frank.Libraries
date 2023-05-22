namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for the <see cref="CtcpClient.PingResponseReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpPingResponseReceivedEventArgs : CtcpResponseReceivedEventArgs
{
    /// <inheritdoc />
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpPingResponseReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="pingTime">The ping time.</param>
    public CtcpPingResponseReceivedEventArgs(IrcUser user, TimeSpan pingTime)
        : base(user) =>
        PingTime = pingTime;

    /// <summary>
    ///     Gets the duration of time elapsed between the sending of the ping request and the receiving of the ping
    ///     response.
    /// </summary>
    /// <value>The ping time.</value>
    public TimeSpan PingTime { get; }
}