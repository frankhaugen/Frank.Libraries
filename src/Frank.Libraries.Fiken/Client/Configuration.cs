namespace Frank.Libraries.Fiken.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        public string BaseUrl { get; set; } = "https://api.fiken.no/api/v2";
        public string Token { get; set; }
        public int Timeout { get; set; } = -1;
    }
}