using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList
{
    public class Self
    {
        [JsonProperty("href")] public string? Href { get; set; }
    }
}