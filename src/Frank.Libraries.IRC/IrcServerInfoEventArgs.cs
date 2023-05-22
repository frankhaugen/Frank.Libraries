namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that specify information about a server.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServerInfoEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcServerInfoEventArgs" /> class.
    /// </summary>
    /// <param name="address">The address of the server.</param>
    /// <param name="port">The port on which to connect to the server.</param>
    public IrcServerInfoEventArgs(string address, int port)
    {
        if (address == null)
        {
            throw new ArgumentNullException("address");
        }

        if (port <= 0)
        {
            throw new ArgumentOutOfRangeException("port");
        }

        Address = address;
        Port = port;
    }

    /// <summary>
    ///     Gets the address of the server.
    /// </summary>
    /// <value>The address of the server.</value>
    public string Address { get; }

    /// <summary>
    ///     Gets the port on which to connect to the server.
    /// </summary>
    /// <value>The port on which to connect to the server.</value>
    public int Port { get; }
}