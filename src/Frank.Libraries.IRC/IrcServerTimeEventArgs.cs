namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ServerTimeReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServerTimeEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcServerTimeEventArgs" /> class.
    /// </summary>
    /// <param name="serverName">The name of the server.</param>
    /// <param name="dateTime">The local date/time received from the server.</param>
    public IrcServerTimeEventArgs(string serverName, string dateTime)
    {
        if (serverName == null)
        {
            throw new ArgumentNullException("serverName");
        }

        if (dateTime == null)
        {
            throw new ArgumentNullException("dateTime");
        }

        ServerName = serverName;
        DateTime = dateTime;
    }

    /// <summary>
    ///     Gets the name of the server to which the version information applies.
    /// </summary>
    /// <value>The name of the server.</value>
    public string ServerName { get; }

    /// <summary>
    ///     Gets the local date/time for the server.
    /// </summary>
    /// <value>The local date/time for the server.</value>
    public string DateTime { get; }
}