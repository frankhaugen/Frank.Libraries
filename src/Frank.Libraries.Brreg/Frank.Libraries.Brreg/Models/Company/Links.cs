using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Company;

public class Links
{
    [JsonProperty("self")] public Self? Self { get; set; }
}