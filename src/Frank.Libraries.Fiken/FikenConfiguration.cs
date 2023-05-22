namespace Frank.Libraries.Fiken;

/// <summary>
///     Represents a set of configuration settings for Fiken
/// </summary>
public class FikenConfiguration
{
    public string BaseUrl { get; set; } = "https://api.fiken.no/api/v2";
    public string Token { get; set; }
    public int Timeout { get; set; } = -1;
}