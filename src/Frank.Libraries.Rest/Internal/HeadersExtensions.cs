namespace Frank.Libraries.Rest.Internal;

public static class HeadersExtensions
{
    public static Dictionary<string, string> ToDictionary(this Headers source) => source._headers;
}