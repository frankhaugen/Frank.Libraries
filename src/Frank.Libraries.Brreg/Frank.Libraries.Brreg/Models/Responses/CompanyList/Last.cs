using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList;

public class Last
{
    [JsonProperty("href")] public string? Href { get; set; }
}