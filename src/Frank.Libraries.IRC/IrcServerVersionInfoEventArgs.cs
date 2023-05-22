namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ServerVersionInfoReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServerVersionInfoEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcServerVersionInfoEventArgs" /> class.
    /// </summary>
    /// <param name="version">The version of the server.</param>
    /// <param name="debugLevel">The debug level of the server.</param>
    /// <param name="serverName">The name of the server.</param>
    /// <param name="comments">The comments about the server.</param>
    public IrcServerVersionInfoEventArgs(string version, string debugLevel, string serverName, string comments)
    {
        if (version == null)
        {
            throw new ArgumentNullException("version");
        }

        if (debugLevel == null)
        {
            throw new ArgumentNullException("debugLevel");
        }

        if (serverName == null)
        {
            throw new ArgumentNullException("serverName");
        }

        if (comments == null)
        {
            throw new ArgumentNullException("comments");
        }

        Version = version;
        DebugLevel = debugLevel;
        ServerName = serverName;
        Comments = comments;
    }

    /// <summary>
    ///     Gets the version of the server.
    /// </summary>
    /// <value>The version of the server.</value>
    public string Version { get; }

    /// <summary>
    ///     Gets the debug level of the server.
    /// </summary>
    /// <value>The debug level of the server.</value>
    public string DebugLevel { get; }

    /// <summary>
    ///     Gets the name of the server to which the version information applies.
    /// </summary>
    /// <value>The name of the server.</value>
    public string ServerName { get; }

    /// <summary>
    ///     Gets the comments about the server.
    /// </summary>
    /// <value>The comments about the server.</value>
    public string Comments { get; }
}