using System.Collections.ObjectModel;

namespace Frank.Libraries.IRC;

/// <summary>
///     Provides data for the <see cref="IrcClient.ServerStatsReceived" /> event.
/// </summary>
/// <threadsafety static="true" instance="false" />
public class IrcServerStatsReceivedEventArgs : EventArgs
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="IrcServerStatsReceivedEventArgs" /> class.
    /// </summary>
    /// <param name="entries">A list of statistical entries that was returned by the server.</param>
    public IrcServerStatsReceivedEventArgs(IList<IrcServerStatisticalEntry> entries)
    {
        if (entries == null)
        {
            throw new ArgumentNullException("entries");
        }

        Entries = new ReadOnlyCollection<IrcServerStatisticalEntry>(entries);
    }

    /// <summary>
    ///     Gets the list of statistical entries that was returned by the server.
    /// </summary>
    /// <value>The list of statistical entries.</value>
    public IList<IrcServerStatisticalEntry> Entries { get; }
}