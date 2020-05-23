using System;

namespace Frank.Extensions.AzureStorage.FileShare.Exceptions
{
    public class FileshareDownloadException : Exception
    {
        public FileshareDownloadException(string message, Exception e) : base(message, e)
        {
        }
    }
}