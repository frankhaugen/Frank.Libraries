namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that specify a name.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcCommentEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcCommentEventArgs" /> class.
    /// </summary>
    /// <param name="comment">The comment that the event specified.</param>
    public IrcCommentEventArgs(string comment) => Comment = comment;

    /// <summary>
    ///     Gets the comment that the event specified.
    /// </summary>
    /// <value>The comment that the event specified.</value>
    public string Comment { get; }
}