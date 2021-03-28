namespace Frank.Libraries.CodeGeneration.Extensions
{
    public static class NullablesExtensions
    {
        public static T FallbackIfNull<T>(this T? source, T fallbackValue) => source ?? fallbackValue;
    }
}