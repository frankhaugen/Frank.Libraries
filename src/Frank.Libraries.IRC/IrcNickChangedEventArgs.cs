#if !SILVERLIGHT

#endif

namespace Frank.Libraries.IRC
{
    /// <summary>
    ///     Provides data for the <see cref="IrcClient.IrcNickChangedEventArgs" /> event.
    /// </summary>
    public class IrcNickChangedEventArgs : EventArgs
    {
        /// <summary>
        ///     Provides the new nickname.
        /// </summary>
        public readonly string NewNickName;

        /// <summary>
        ///     Provides the old nickname.
        /// </summary>
        public readonly string OldNickName;

        /// <summary>
        ///     Initializes a new instance of the <see cref="IrcNickChangedEventArgs" /> class.
        /// </summary>
        /// <param name="newNickName"></param>
        /// <param name="oldNickName"></param>
        public IrcNickChangedEventArgs(string newNickName, string oldNickName)
        {
            NewNickName = newNickName;
            OldNickName = oldNickName;
        }
    }

#if !SILVERLIGHT

#endif
}