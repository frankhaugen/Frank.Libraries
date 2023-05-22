using System.Collections.ObjectModel;
using System.Text;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for events that are raised when an IRC message or notice is sent or received.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcMessageEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcMessageEventArgs" /> class.
    /// </summary>
    /// <param name="source">The source of the message.</param>
    /// <param name="targets">A list of the targets of the message.</param>
    /// <param name="text">The text of the message.</param>
    /// <param name="encoding">The encoding of the message text.</param>
    /// <exception cref="ArgumentNullException"><paramref name="targets" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="text" /> is <see langword="null" />.</exception>
    public IrcMessageEventArgs(IIrcMessageSource source, IList<IIrcMessageTarget> targets, string text,
                               Encoding encoding)
    {
        if (targets == null)
        {
            throw new ArgumentNullException("target");
        }

        if (text == null)
        {
            throw new ArgumentNullException("text");
        }

        if (encoding == null)
        {
            throw new ArgumentNullException("textEncoding");
        }

        Source = source;
        Targets = new ReadOnlyCollection<IIrcMessageTarget>(targets);
        Text = text;
        Encoding = encoding;
    }

    /// <summary>
    ///     Gets the source of the message.
    /// </summary>
    /// <value>The source of the message.</value>
    public IIrcMessageSource Source { get; }

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

    /// <summary>
    ///     Gets the encoding of the message text.
    /// </summary>
    /// <value>The encoding of the message text.</value>
    public Encoding Encoding { get; }

    /// <summary>
    ///     Gets the text of the message in the specified encoding.
    /// </summary>
    /// <param name="encoding">
    ///     The encoding in which to get the message text, or <see langword="null" /> to use the
    ///     default encoding.
    /// </param>
    /// <returns>The text of the message.</returns>
    public string GetText(Encoding encoding = null) => Text.ChangeEncoding(Encoding, encoding);
}