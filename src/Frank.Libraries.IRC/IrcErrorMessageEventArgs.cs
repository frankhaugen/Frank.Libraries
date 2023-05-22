namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ErrorMessageReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcErrorMessageEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcErrorMessageEventArgs" /> class.
    /// </summary>
    /// <param name="message">The error message given by the server.</param>
    public IrcErrorMessageEventArgs(string message)
    {
        if (message == null)
        {
            throw new ArgumentNullException("message");
        }

        Message = message;
    }

    /// <summary>
    ///     Gets the text of the error message.
    /// </summary>
    /// <value>The text of the error message.</value>
    public string Message { get; }
}