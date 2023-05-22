namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that concern an <see cref="IrcUser" />.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcUserEventArgs : IrcCommentEventArgs
{
    /// <inheritdoc />
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcUserEventArgs" /> class.
    /// </summary>
    /// <param name="user">The user that the event concerns, or <see langword="null" /> for no user.</param>
    public IrcUserEventArgs(IrcUser user, string comment = null)
        : base(comment) =>
        User = user;

    /// <summary>
    ///     Gets the user that the event concerns.
    /// </summary>
    /// <value>The user that the event concerns.</value>
    public IrcUser User { get; }
}