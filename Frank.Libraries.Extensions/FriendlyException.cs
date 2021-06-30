using System;

namespace Frank.Libraries.Extensions
{
    public class FriendlyException
    {
        public FriendlyException(string title, string message, string? stackTrace, Exception? innerException = null)
        {
            Title = title;
            Message = message;
            StackTrace = stackTrace;

            if (innerException != null)
                InnerFriendlyException = innerException.GetFriendly();
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public string? StackTrace { get; set; }
        public FriendlyException? InnerFriendlyException { get; set; }
    }
}