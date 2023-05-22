namespace Frank.Libraries.Rest;

public static class UrlExtensions
{
    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the given URL is null.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    /// <param name="paramName">The name of the parameter being checked.</param>
    public static void ThrowIfNull(this IUrl url, string paramName)
    {
        if (url == null)
        {
            throw new ArgumentNullException(paramName, $"The {paramName} cannot be null.");
        }
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the scheme of the given URL is null or empty.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    public static void ThrowIfSchemeNullOrEmpty(this IUrl url)
    {
        if (!Enum.IsDefined(url.Scheme))
        {
            throw new ArgumentNullException("The scheme of the URL cannot be null or empty.");
        }
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentNullException" /> if the hostname of the given URL is null or empty.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    public static void ThrowIfHostNullOrEmpty(this IUrl url)
    {
        if (string.IsNullOrEmpty(url.Host))
        {
            throw new ArgumentNullException("The hostname of the URL cannot be null or empty.");
        }
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentException" /> if the given URL is not properly formatted.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    public static void ThrowIfMalformed(this IUrl url)
    {
        url.ThrowIfSchemeNullOrEmpty();
        url.ThrowIfHostNullOrEmpty();
    }

    /// <summary>
    ///     Throws an <see cref="ArgumentException" /> if the given URL has a port that is not a valid port number.
    /// </summary>
    /// <param name="url">The URL to check.</param>
    public static void ThrowIfInvalidPort(this IUrl url)
    {
        if (url.Port < 0 || url.Port > 65535)
        {
            throw new ArgumentException("The URL has an invalid port number. It must be a valid port number (0-65535).");
        }
    }
}