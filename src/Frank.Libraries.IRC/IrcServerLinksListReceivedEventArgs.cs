using System.Collections.ObjectModel;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ServerLinksListReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServerLinksListReceivedEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcServerLinksListReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="links">A list of information about the server links that was returned by the server.</param>
    public IrcServerLinksListReceivedEventArgs(IList<IrcServerInfo> links)
    {
        if (links == null)
        {
            throw new ArgumentNullException("links");
        }

        Links = new ReadOnlyCollection<IrcServerInfo>(links);
    }

    /// <summary>
    ///     Gets the list of information about the server links that was returned by the server
    /// </summary>
    /// <value>The list of server links.</value>
    public IList<IrcServerInfo> Links { get; }
}