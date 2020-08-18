using System;

namespace Frank.Libraries.AzureStorage.FileShare.Exceptions
{
    public class FileshareDownloadException : Exception
    {
        public FileshareDownloadException(string message, Exception e) : base(message, e)
        {
        }
    }
}