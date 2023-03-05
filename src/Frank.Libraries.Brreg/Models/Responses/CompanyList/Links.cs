using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList;

public class Links
{
    [JsonProperty("first")] public First? First { get; set; }

    [JsonProperty("self")] public Self? Self { get; set; }

    [JsonProperty("next")] public Next? Next { get; set; }

    [JsonProperty("last")] public Last? Last { get; set; }
}