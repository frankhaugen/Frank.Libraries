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

        public static string Remove(this string source, string value) => source.Replace(value, "");

        public static string FallbackIfEmpty(this string source, string value)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return value;
            }

            return source;
        }
    }

    public static class RecordExtensions
    {
        //public static List<string> GetUsings(this Type source)
        //{
        //return source.Select(x => x.Name).ToList();
        //return source.Assembly.GetReferencedAssemblies().private Select(x => x.Name).private ToList();

        //}
    }
}