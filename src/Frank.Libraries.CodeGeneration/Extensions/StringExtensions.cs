using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Frank.Libraries.CodeGeneration.Extensions;

public static class StringExtensions
{
    public static string ToCamelcase(this string source)
    {
        var firstCharacter = source.First()
                                   .ToString()
                                   .ToLower();

        source = source.Remove(0, 1);
        source = firstCharacter + source;

        return source;
    }

    public static string Remove(this string source, string value) => source.Replace(value, "");

    public static IOrderedEnumerable<string> Order(this IEnumerable<string> source) => source.OrderBy(x => x);

    public static string Remove(this string source, params string[] values)
    {
        var temp = new string(source.ToCharArray());
        return values.Aggregate(temp, (current, value) => current.Remove(value));
    }

    public static string FallbackIfEmpty(this string source, string value) =>
        string.IsNullOrWhiteSpace(source)
            ? value
            : source;

    public static string ToSentenceCase(this string source) => Regex.Replace(source, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");

    public static string ToNameCase(this string source) => source.ToPascalCase()
                                                                 .Remove(" ", "\n", "\n\r", "\r", "\t");

    public static string ToPascalCase(this string source) => source.ToTitleCase()
                                                                   .Remove(" ")
                                                                   .Remove("\t")
                                                                   .Remove("\n");

    public static string ToCamelCase(this string str)
    {
        if (!string.IsNullOrEmpty(str) && str.Length > 1)
        {
            return char.ToLowerInvariant(str[0]) + str.Substring(1);
        }

        return str.ToLowerInvariant();
    }

    public static string ToTitleCase(this string source)
    {
        var sentenceCase = source.ToSentenceCase();
        var textInfo = new CultureInfo("en-US", false).TextInfo;
        return textInfo.ToTitleCase(sentenceCase);
    }
}