using System;

namespace Frank.Libraries.AzureStorage.FileShare.Exceptions
{
    public class FileshareUploadException : Exception
    {
        public FileshareUploadException(string message, Exception e) : base(message, e)
        {
        }
    }
}