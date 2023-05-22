namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that concern an <see cref="IrcChannelUser" />.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcChannelUserEventArgs : IrcCommentEventArgs
{
    /// <inheritdoc />
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcChannelUserEventArgs" /> class.
    /// </summary>
    /// <param name="channelUser">The channel user that the event concerns.</param>
    public IrcChannelUserEventArgs(IrcChannelUser channelUser, string comment = null)
        : base(comment)
    {
        if (channelUser == null)
        {
            throw new ArgumentNullException("channelUser");
        }

        ChannelUser = channelUser;
    }

    /// <summary>
    ///     Gets the channel user that the event concerns.
    /// </summary>
    /// <value>The channel user that the event concerns.</value>
    public IrcChannelUser ChannelUser { get; }
}