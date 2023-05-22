namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.Error" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcErrorEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcErrorEventArgs" /> class.
    /// </summary>
    /// <param name="error">The error.</param>
    public IrcErrorEventArgs(Exception error)
    {
        if (error == null)
        {
            throw new ArgumentNullException("error");
        }

        Error = error;
    }

    /// <summary>
    ///     Gets the error encountered by the client.
    /// </summary>
    /// <value>The error encountered by the client.</value>
    public Exception Error { get; }
}