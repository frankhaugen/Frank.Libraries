namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for the <see cref="CtcpClient.TimeResponseReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpTimeResponseReceivedEventArgs : CtcpResponseReceivedEventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpTimeResponseReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="dateTime">The local date/time received from the user.</param>
    public CtcpTimeResponseReceivedEventArgs(IrcUser user, string dateTime)
        : base(user) =>
        DateTime = dateTime;

    /// <summary>
    ///     Gets the local date/time for the user.
    /// </summary>
    /// <value>The local date/time for the user.</value>
    public string DateTime { get; }
}