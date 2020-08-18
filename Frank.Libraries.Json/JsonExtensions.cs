using System.Text.Json;

namespace Frank.Libraries.Json
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T source, bool indented = true) where T : class
        {
            return JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = indented });
        }

    }
}
