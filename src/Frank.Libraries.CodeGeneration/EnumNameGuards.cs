using System.Text.RegularExpressions;

namespace Frank.Libraries.CodeGeneration.Generators;

internal static class EnumNameGuards
{
    public static string EnumNameGuard(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
        }

        var enumNameRegex = new Regex(@"^[a-zA-Z0-9]+$");

        if (!enumNameRegex.IsMatch(name))
        {
            throw new ArgumentException("Value must be alphanumeric.", nameof(name));
        }

        return name;
    }
}