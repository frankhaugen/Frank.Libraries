using System.Collections.ObjectModel;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ProtocolError" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcProtocolErrorEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcProtocolErrorEventArgs" /> class.
    /// </summary>
    /// <param name="code">The code.</param>
    /// <param name="parameters">The parameters.</param>
    /// <param name="message">The message.</param>
    public IrcProtocolErrorEventArgs(int code, IList<string> parameters, string message)
    {
        if (parameters == null)
        {
            throw new ArgumentNullException("parameters");
        }

        if (message == null)
        {
            throw new ArgumentNullException("message");
        }

        Code = code;
        Parameters = new ReadOnlyCollection<string>(parameters);
        Message = message;
    }

    /// <summary>
    ///     Gets or sets the numeric code that indicates the type of error.
    /// </summary>
    /// <value>The numeric code that indicates the type of error.</value>
    public int Code { get; }

    /// <summary>
    ///     Gets a list of the parameters of the error.
    /// </summary>
    /// <value>A lsit of the parameters of the error.</value>
    public IList<string> Parameters { get; }

    /// <summary>
    ///     Gets the text of the error message.
    /// </summary>
    /// <value>The text of the error message.</value>
    public string Message { get; }
}