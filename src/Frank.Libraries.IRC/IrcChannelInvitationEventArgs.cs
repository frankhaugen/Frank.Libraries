namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.PingReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcChannelInvitationEventArgs : IrcChannelEventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcChannelInvitationEventArgs" /> class.
    /// </summary>
    /// <param name="channel">The channel to which the recipient user is invited.</param>
    /// <param name="inviter">The user inviting the recipient user to the channel.</param>
    public IrcChannelInvitationEventArgs(IrcChannel channel, IrcUser inviter)
        : base(channel)
    {
        if (inviter == null)
        {
            throw new ArgumentNullException("inviter");
        }

        Inviter = inviter;
    }

    /// <summary>
    ///     Gets the user inviting the recipient user to the channel
    /// </summary>
    /// <value>The inviter user.</value>
    public IrcUser Inviter { get; }
}