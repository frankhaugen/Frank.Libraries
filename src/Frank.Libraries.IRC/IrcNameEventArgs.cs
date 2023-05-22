namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that specify a comment.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcNameEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcNameEventArgs" /> class.
    /// </summary>
    /// <param name="name">The name that the event specified.</param>
    public IrcNameEventArgs(string name) => Name = name;

    /// <summary>
    ///     Gets the name that the event specified.
    /// </summary>
    /// <value>The name that the event specified.</value>
    public string Name { get; }
}