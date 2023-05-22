namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for events that indicate a response to a CTCP request.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpResponseReceivedEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpResponseReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="user">The user from which the response was received.</param>
    public CtcpResponseReceivedEventArgs(IrcUser user) => User = user;

    /// <summary>
    ///     Gets the user from which the response was received.
    /// </summary>
    /// <value>The user from which the request was received.</value>
    public IrcUser User { get; }
}