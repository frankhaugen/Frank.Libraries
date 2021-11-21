using System;
using System.Text.Json;

namespace Frank.Libraries.Extensions
{
    public static class ExceptionExtensions
    {
        public static FriendlyException GetFriendly<T>(this T source) where T : Exception
        {
            return new FriendlyException(source.GetType()
                                               .Name.ToTitleCase(), source.Message, source.StackTrace,
                                         source.InnerException);
        }

        public static string ToJson(this FriendlyException source)
        {
            return JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = true, IgnoreNullValues = true, MaxDepth = 1 });
        }
    }
}