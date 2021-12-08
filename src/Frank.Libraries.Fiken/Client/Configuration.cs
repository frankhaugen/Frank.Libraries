namespace Frank.Libraries.Fiken.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        public string BaseUrl { get; set; } = "https://api.fiken.no/api/v2";
        public string Token { get; set; } = "2437558476.PxmK1I08p23Oi4gRjeOwtJOS5xksZzA3";
        public string CampanySlug { get; set; }
        public int Timeout { get; set; } = -1;
    }
}