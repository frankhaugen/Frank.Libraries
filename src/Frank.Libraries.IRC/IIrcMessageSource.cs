﻿namespace Frank.Libraries.IRC
{
    /// <summary>
    ///     Represents the source of a message or notice sent by an IRC client.
    /// </summary>
    public interface IIrcMessageSource
    {
        /// <summary>
        ///     Gets the name of the source, as understood by the IRC protocol.
        /// </summary>
        /// <value>The name of the source.</value>
        string Name { get; }
    }
}