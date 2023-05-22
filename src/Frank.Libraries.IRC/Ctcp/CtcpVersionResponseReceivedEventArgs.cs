namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for the <see cref="CtcpClient.VersionResponseReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpVersionResponseReceivedEventArgs : CtcpResponseReceivedEventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpVersionResponseReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="versionInfo">The information about the client version.</param>
    public CtcpVersionResponseReceivedEventArgs(IrcUser user, string versionInfo)
        : base(user) =>
        VersionInfo = versionInfo;

    /// <summary>
    ///     Gets the information about the client version of the user.
    /// </summary>
    /// <value>The ping time.</value>
    public string VersionInfo { get; }
}