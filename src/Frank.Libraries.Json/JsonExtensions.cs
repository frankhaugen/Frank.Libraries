using System.Text.Json;

namespace Frank.Libraries.Json
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T source, bool indented = true) where T : class
        {
            return JsonSerializer.Serialize(source, new JsonSerializerOptions() { WriteIndented = indented });
        }

        public static T FromJson<T>(this string source) where T : class
        {
            return JsonSerializer.Deserialize<T>(source)!;
        }


        // THIS: (C): https://stackoverflow.com/questions/2434534/serialize-an-object-to-string
        /// <summary>
        /// A helper to serialize an object to a string containing XML data of the object.
        /// </summary>
        /// <typeparam name="T">An object to serialize to a XML data string.</typeparam>
        /// <param name="toSerialize">A helper method for any type of object to be serialized to a XML data string.</param>
        /// <returns>A string containing XML data of the object.</returns>
        public static string SerializeObjectToJson<T>(this T value) where T : class, new()
        {
            // serialize a class to a StringWriter class instance..
            return JsonSerializer.Serialize(value, new JsonSerializerOptions() {WriteIndented = true});                     // return the value..
        }
    }
}