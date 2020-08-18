using System;

namespace Frank.Libraries.Logging
{
    public class SqlLoggerException : Exception
    {
        public SqlLoggerException(string message) : base(message)
        {
        }
    }
}