namespace Frank.Libraries.IRC;

/// <summary>
///     Defines the types of channels. Each channel may only be of a single type at any one time.
/// </summary>
public enum IrcChannelType
{
    /// <summary>
    ///     The channel type is unspecified.
    /// </summary>
    Unspecified,

    /// <summary>
    ///     The channel is public. The server always lists this channel.
    /// </summary>
    Public,

    /// <summary>
    ///     The channel is private. The server never lists this channel.
    /// </summary>
    Private,

    /// <summary>
    ///     The channel is secret. The server never lists this channel and pretends it does not exist when responding to
    ///     queries.
    /// </summary>
    Secret
}