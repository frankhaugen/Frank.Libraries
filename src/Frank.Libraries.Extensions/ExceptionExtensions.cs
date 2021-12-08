using System;
using System.Collections.Generic;

namespace Frank.Libraries.Extensions
{
    public static class ExceptionExtensions
    {
        public static List<Exception> GetAll<T>(this T exception) where T : Exception
        {
            var exceptions = new List<Exception>();
            var currentException = exception as Exception;

            while (currentException != null)
            {
                exceptions.Add(currentException);
                currentException = currentException.InnerException;
            }

            return exceptions;
        }
    }
}