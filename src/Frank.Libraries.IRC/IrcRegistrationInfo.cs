namespace Frank.Libraries.IRC;

/// <summary>
///     Provides information used by an <see cref="IrcClient" /> for registering the connection with the server.
/// </summary>
/// <threadsafety static="true" instance="false" />
public abstract class IrcRegistrationInfo
{
    /// <summary>
    ///     Gets or sets the password for registering with the server.
    /// </summary>
    /// <value>The password for registering with the server.</value>
    public string Password { get; set; }

    /// <summary>
    ///     Gets or sets the nick name of the local user to set initially upon registration.
    ///     The nick name can be changed after registration.
    /// </summary>
    /// <value>The initial nick name of the local user.</value>
    public string NickName { get; set; }
}