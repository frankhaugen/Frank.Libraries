namespace Frank.Libraries.Csv;

internal static class StringEnumerableExtensions
{
    public static string ConcatWith(this IEnumerable<string> source, string delimiter)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (delimiter == null)
        {
            throw new ArgumentNullException(nameof(delimiter));
        }

        return string.Join(delimiter, source);
    }
}