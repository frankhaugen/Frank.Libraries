using System;
using System.Collections.Generic;

namespace Frank.Libraries.Rest;

/// <summary>
///     Defines an interface for building a URL.
/// </summary>
public interface IUrl
{
    /// <summary>
    ///     Gets or sets the scheme of the URL (e.g. "http" or "https").
    /// </summary>
    HttpScheme Scheme { get; }

    /// <summary>
    ///     Gets or sets the hostname of the URL (e.g. "example.com").
    /// </summary>
    string Host { get; }

    /// <summary>
    ///     Gets or sets the port of the URL (e.g. 80).
    /// </summary>
    int Port { get; }

    /// <summary>
    ///     Gets or sets the path of the URL (e.g. "/path/to/resource").
    /// </summary>
    string Path { get; }

    /// <summary>
    ///     Gets or sets the query parameters of the URL as a list of key-value pairs (e.g. "key1=value1&key2=value2").
    /// </summary>
    IList<KeyValuePair<string, string>> QueryParams { get; }

    /// <summary>
    ///     Gets or sets the user info of the URL (e.g. "username:password").
    /// </summary>
    string UserInfo { get; }

    /// <summary>
    ///     Adds a scheme to the URL.
    /// </summary>
    /// <param name="scheme">The scheme to add to the URL (e.g. "http" or "https").</param>
    /// <returns>The URL with the added scheme.</returns>
    IUrl AddScheme(HttpScheme scheme);

    /// <summary>
    ///     Adds a hostname to the URL.
    /// </summary>
    /// <param name="host">The hostname to add to the URL (e.g. "example.com").</param>
    /// <returns>The URL with the added hostname.</returns>
    IUrl AddHost(string host);

    /// <summary>
    ///     Adds a port to the URL.
    /// </summary>
    /// <param name="port">The port to add to the URL (e.g. 80).</param>
    /// <returns>The URL with the added port.</returns>
    IUrl AddPort(int port);

    /// <summary>
    ///     Adds a path to the URL.
    /// </summary>
    /// <param name="path">The path to add to the URL (e.g. "/path/to/resource").</param>
    /// <returns>The URL with the added path.</returns>
    IUrl AddPath(string path);

    /// <summary>
    ///     Adds a query parameter to the URL.
    /// </summary>
    /// <param name="key">The key of the query parameter to add (e.g. "key").</param>
    /// <param name="value">The value of the query parameter to add (e.g. "value").</param>
    /// <returns>The URL with the added query parameter.</returns>
    IUrl AddQueryParam(string key, string value);

    /// <summary>
    ///     Adds multiple query parameters to the URL.
    /// </summary>
    /// <param name="queryParams">
    ///     The query parameters to add to the URL as a list of key-value pairs (e.g. "key1=value1&key2
    ///     =value2").
    /// </param>
    /// <returns>The URL with the added query parameters.</returns>
    IUrl AddQueryParams(IList<KeyValuePair<string, string>> queryParams);

    /// <summary>
    ///     Adds user info to the URL.
    /// </summary>
    /// <param name="userInfo">The user info to add to the URL (e.g. "username:password").</param>
    /// <returns>The URL with the added user info.</returns>
    IUrl AddUserInfo(string userInfo);

    /// <summary>
    ///     Builds the URL as a string.
    /// </summary>
    /// <returns>The URL as a string.</returns>
    string Build();

    /// <summary>
    ///     Builds the URL as a <see cref="Uri" /> object.
    /// </summary>
    /// <returns>The URL as a <see cref="Uri" /> object.</returns>
    Uri ToUri();
}