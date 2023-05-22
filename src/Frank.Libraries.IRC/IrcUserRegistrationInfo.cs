namespace Frank.Libraries.IRC;

/// <summary>
///     Provides information used by an <see cref="IrcClient" /> for registering the connection as a user.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcUserRegistrationInfo : IrcRegistrationInfo
{
    /// <summary>
    ///     Gets or sets the user name of the local user to set upon registration.
    ///     The user name cannot later be changed.
    /// </summary>
    /// <value>The user name of the local user.</value>
    public string UserName { get; set; }

    /// <summary>
    ///     Gets or sets the real name of the local user to set upon registration.
    ///     The real name cannot later be changed.
    /// </summary>
    /// <value>The real name of the local user.</value>
    public string RealName { get; set; }

    /// <summary>
    ///     Gets or sets the modes of the local user to set initially.
    ///     The collection should not contain any characters except 'w' or 'i'.
    ///     The modes can be changed after registration.
    /// </summary>
    /// <value>A collection of modes to set on the local user.</value>
    public ICollection<char> UserModes { get; set; }
}