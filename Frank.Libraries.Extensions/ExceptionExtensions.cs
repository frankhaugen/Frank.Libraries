using System;
using System.Text.Json;

namespace Frank.Libraries.Extensions
{
    public static class ExceptionExtensions
    {
        public static FriendlyException GetFriendly<T>(this T source) where T : Exception
        {
            return new FriendlyException(source.GetType().Name.ToTitleCase(), source.Message, source.StackTrace,
                source.InnerException);
        }

        public static string ToJson(this FriendlyException source)
        {
            return JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = true, IgnoreNullValues = true, MaxDepth = 1 });
        }
    }

    public class FriendlyException
    {
        public FriendlyException(string title, string message, string stackTrace, Exception? innerException = null)
        {
            Title = title;
            Message = message;
            StackTrace = stackTrace;

            if (innerException != null)
                InnerFriendlyException = innerException.GetFriendly();
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public FriendlyException? InnerFriendlyException { get; set; }
    }
}
