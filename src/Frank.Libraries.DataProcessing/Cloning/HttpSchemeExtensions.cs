namespace Frank.Libraries.DataProcessing.Cloning;

public static class HttpSchemeExtensions
{
    public static string ToSchemeStringWithTrail(this HttpScheme httpScheme) => httpScheme.ToSchemeString() + "://";

    public static string ToSchemeString(this HttpScheme httpScheme)
    {
        return httpScheme switch
        {
            HttpScheme.Http  => "http",
            HttpScheme.Https => "https",
            _                => throw new ArgumentOutOfRangeException(nameof(httpScheme), httpScheme, null)
        };
    }
}