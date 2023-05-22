namespace Frank.Libraries.Extensions;

public static class EnumExtensions
{
    public static string AsString<T>(this T source) where T : Enum => Enum.GetName(typeof(T), source) ?? string.Empty;

    public static int AsInteger<T>(this T source) where T : Enum => Convert.ToInt32(source);
}