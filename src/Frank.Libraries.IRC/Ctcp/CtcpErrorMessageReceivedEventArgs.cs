namespace Frank.Libraries.IRC.Ctcp;

/// <summary>
///     Provides data for the <see cref="CtcpClient.ErrorMessageReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class CtcpErrorMessageReceivedEventArgs : CtcpResponseReceivedEventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpErrorMessageReceivedEventArgs" /> class,
    ///     specifying that no error occurred.
    /// </summary>
    /// <param name="noErrorMessage">The message indicating that no error occurred.</param>
    public CtcpErrorMessageReceivedEventArgs(IrcUser user, string noErrorMessage)
        : base(user)
    {
        ErrorOccurred = false;
        FailedQuery = null;
        ErrorMessage = noErrorMessage;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CtcpErrorMessageReceivedEventArgs" /> class,
    ///     specifying the query that failed with an error message.
    /// </summary>
    /// <param name="failedQuery">A string containing the query that failed.</param>
    /// <param name="errorMessage">The message describing the error that occurred for the remote user.</param>
    public CtcpErrorMessageReceivedEventArgs(IrcUser user, string failedQuery, string errorMessage)
        : base(user)
    {
        ErrorOccurred = true;
        FailedQuery = failedQuery;
        ErrorMessage = errorMessage;
    }

    /// <summary>
    ///     Gets a value indicating whether an error occurred or the user confirmed that no error occurred.
    /// </summary>
    /// <value>
    ///     <see langword="true" /> if an error occurred; <see langword="false" /> if the remote user confirmed
    ///     that no error occurred.
    /// </value>
    public bool ErrorOccurred { get; }

    /// <summary>
    ///     Gets a string containing the query that failed
    /// </summary>
    /// <value>The failed query.</value>
    public string FailedQuery { get; }

    /// <summary>
    ///     Gets message describing the error that occurred for the remote user.
    /// </summary>
    /// <value>The error message.</value>
    public string ErrorMessage { get; }
}