using System;

namespace Frank.Libraries.AzureStorage.FileShare.Exceptions
{
    /// <summary>
    /// A custom exception for upload failures
    /// </summary>
    public class FileshareUploadException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e">Inner Exception</param>
        public FileshareUploadException(string message, Exception e) : base(message, e)
        {
        }
    }
}