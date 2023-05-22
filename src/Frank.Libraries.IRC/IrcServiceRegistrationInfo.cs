namespace Frank.Libraries.IRC;

/// <summary>
///     Provides information used by an <see cref="IrcClient" /> for registering the connection as a service.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServiceRegistrationInfo : IrcRegistrationInfo
{
    /// <summary>
    ///     Gets or sets the distribution of the service, which determines its visibility to users on specific servers.
    /// </summary>
    /// <value>
    ///     A wildcard expression for matching against the names of servers on which the service should be
    ///     visible.
    /// </value>
    public string Distribution { get; set; }

    /// <summary>
    ///     Gets or sets the description of the service to set upon registration.
    ///     The description cannot later be changed.
    /// </summary>
    /// <value>A description of the service.</value>
    public string Description { get; set; }
}