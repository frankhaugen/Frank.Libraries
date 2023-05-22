namespace Frank.Libraries.DataProcessing.Cloning;

public class ClientOptions
{
    public Uri BaseUrl { get; set; }
    public bool ForceInternalToken { get; set; }
    public int? Timeout { get; set; }
}