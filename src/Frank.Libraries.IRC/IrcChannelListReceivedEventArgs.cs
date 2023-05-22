using System.Collections.ObjectModel;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ChannelListReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcChannelListReceivedEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcChannelListReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="channels">A list of information about the channels that was returned by the server.</param>
    public IrcChannelListReceivedEventArgs(IList<IrcChannelInfo> channels)
    {
        if (channels == null)
        {
            throw new ArgumentNullException("channels");
        }

        Channels = new ReadOnlyCollection<IrcChannelInfo>(channels);
    }

    /// <summary>
    ///     Gets the list of information about the channels that was returned by the server.
    /// </summary>
    /// <value>The list of channels.</value>
    public IList<IrcChannelInfo> Channels { get; }
}