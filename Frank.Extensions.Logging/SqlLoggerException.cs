using System;

namespace Frank.Extensions.Logging
{
    public class SqlLoggerException : Exception
    {
        public SqlLoggerException(string message) : base(message)
        {
        }
    }
}