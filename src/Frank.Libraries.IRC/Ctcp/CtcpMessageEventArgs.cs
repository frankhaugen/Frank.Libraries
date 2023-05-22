using System.Collections.ObjectModel;

namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for events that are raised when a CTCP message or notice is sent or received.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpMessageEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpMessageEventArgs" /> class.
    /// </summary>
    /// <param name="source">The source of the message.</param>
    /// <param name="targets">A list of the targets of the message.</param>
    /// <param name="text">The text of the message.</param>
    /// <exception cref="ArgumentNullException"><paramref name="targets" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="text" /> is <see langword="null" />.</exception>
    public CtcpMessageEventArgs(IrcUser source, IList<IIrcMessageTarget> targets, string text)
    {
        if (targets == null)
        {
            throw new ArgumentNullException("target");
        }

        if (text == null)
        {
            throw new ArgumentNullException("text");
        }

        Source = source;
        Targets = new ReadOnlyCollection<IIrcMessageTarget>(targets);
        Text = text;
    }

    /// <summary>
    ///     Gets the source of the message.
    /// </summary>
    /// <value>The source of the message.</value>
    public IrcUser Source { get; }

    /// <summary>
    ///     Gets a list of the targets of the message.
    /// </summary>
    /// <value>The targets of the message.</value>
    public IList<IIrcMessageTarget> Targets { get; }

    /// <summary>
    ///     Gets the text of the message.
    /// </summary>
    /// <value>The text of the message.</value>
    public string Text { get; }
}