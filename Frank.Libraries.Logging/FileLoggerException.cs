using System;

namespace Frank.Libraries.Logging
{
    public class FileLoggerException : Exception
    {
        public FileLoggerException(string message) : base(message)
        {
        }
    }
}
