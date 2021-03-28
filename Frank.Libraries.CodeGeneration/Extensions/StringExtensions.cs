using System.Linq;

namespace Frank.Libraries.CodeGeneration.Extensions
{
    public static class StringExtensions
    {
        public static string ToCamelcase(this string source)
        {
            var firstCharacter = source.First().ToString().ToLower();

            source = source.Remove(0, 1);
            source = firstCharacter + source;

            return source;
        }
    }
}