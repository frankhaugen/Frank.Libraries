using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

    public static class TaskExtensions
    {
        public static async Task<TaskResult<T>> RunTaskAsync<T>(this Task<T> task)
        {
            try
            {
                return new TaskResult<T>(false, await task, null);
            }
            catch (Exception e)
            {
                return new TaskResult<T>(false, default, e);
            }
        }
    }

    public record TaskResult<T>(bool Success, T? Value, Exception? Exception);
}