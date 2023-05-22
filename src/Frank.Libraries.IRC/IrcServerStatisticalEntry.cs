namespace Frank.Libraries.IRC;

/// <summary>
///     Stores a statistical entry for an IRC server.
/// </summary>
public struct IrcServerStatisticalEntry
{
    /// <summary>
    ///     The type of the statistical entry.
    /// </summary>
    public int Type;

    /// <summary>
    ///     The list of parameters of the statistical entry.
    /// </summary>
    public IList<string> Parameters;
}