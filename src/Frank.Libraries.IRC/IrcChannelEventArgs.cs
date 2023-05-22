namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that concern an <see cref="IrcChannel" />.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcChannelEventArgs : IrcCommentEventArgs
{
    /// <inheritdoc />
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcChannelEventArgs" /> class.
    /// </summary>
    /// <param name="channel">The channel that the event concerns.</param>
    public IrcChannelEventArgs(IrcChannel channel, string comment = null)
        : base(comment)
    {
        if (channel == null)
        {
            throw new ArgumentNullException("channel");
        }

        Channel = channel;
    }

    /// <summary>
    ///     Gets the channel that the event concerns.
    /// </summary>
    /// <value>The channel that the event concerns.</value>
    public IrcChannel Channel { get; }
}