namespace Frank.Libraries.DataProcessing.Cloning;

public static class DefaultPortExtensions
{
    public static Port ToDefaultPort(this HttpScheme httpScheme)
    {
        return httpScheme switch
        {
            HttpScheme.Http  => new PortList().Single(x => x.Value == 80),
            HttpScheme.Https => new PortList().Single(x => x.Value == 443),
            _                => throw new ArgumentOutOfRangeException(nameof(httpScheme), httpScheme, null)
        };
    }
}