using System.Text;

namespace Frank.Libraries.IRC;

/// <summary>
///     <inheritdoc select="/summary/node()" />
///     Gives the option to handle the preview event and thus stop the normal event from being raised.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcPreviewMessageEventArgs : IrcMessageEventArgs
{
    /// <inheritdoc />
    public IrcPreviewMessageEventArgs(IIrcMessageSource source, IList<IIrcMessageTarget> targets, string text,
                                      Encoding encoding)
        : base(source, targets, text, encoding) =>
        Handled = false;

    /// <summary>
    ///     Gets or sets whether the event has been handled. If it is handled, the corresponding normal (non-preview)
    ///     event is not raised.
    /// </summary>
    /// <value><see langword="true" /> if the event has been handled; <see langword="false" />, otherwise.</value>
    public bool Handled { get; set; }
}