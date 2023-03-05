using System;

namespace Frank.Libraries.AzureStorage.FileShare.Exceptions;

/// <summary>
///     A generic exception for file share operations
/// </summary>
public class FileshareDownloadException : Exception
{
    /// <summary />
    /// <param name="message"></param>
    /// <param name="e"></param>
    public FileshareDownloadException(string message, Exception e) : base(message, e)
    {
    }
}