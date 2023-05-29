using System.Text.RegularExpressions;

namespace Frank.Libraries.Json;

internal static partial class TypeExtensions
{
    public static string GetSafeName(this Type type)
    {
        var typeName = type.Name;
        var regex = MyRegex();
        var name = regex.Replace(typeName, "");
        name = name.Length > 50 ? name.Substring(0, 50) : name;
        return name;
    }

    [GeneratedRegex("[^a-zA-Z-]")]
    private static partial Regex MyRegex();
}