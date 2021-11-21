using System;
using System.Collections.Generic;
using System.Globalization;

namespace Frank.Libraries.Logging.Extensions
{
    /// <summary>
    /// Borrowed/Inspired by AppInsights -library
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Concatenate the Message property of an Exception and any InnerExceptions.
        /// </summary>
        /// <param name="ex">Exception to flatten.</param>
        /// <returns>Returns a concatenated string of exception messages.</returns>
        public static string FlattenMessages(this Exception ex)
        {
            var list = new List<string>();

            try
            {
                for (var tempEx = ex; tempEx != null; tempEx = tempEx.InnerException)
                {
                    try
                    {
                        list.Add(tempEx.Message);
                    }
                    catch
                    {
                        list.Add("FailureToParse");
                    }
                }
            }
            catch
            {
                list.Add("FailureToFlatten");
            }

            return string.Join(" | ", list);
        }

        /// <summary>
        /// Get a string representing an Exception. Includes Type and Message.
        /// </summary>
        /// <param name="ex">Input exception.</param>
        /// <returns>Returns a string representing the exception.</returns>
        public static string ToLogString(this Exception ex)
        {
            string msg = "Type: '{0}' Message: '{1}'";
            return string.Format(CultureInfo.InvariantCulture, msg, ex.GetType()
                                                                      .ToString(), ex.FlattenMessages());
        }
    }
}