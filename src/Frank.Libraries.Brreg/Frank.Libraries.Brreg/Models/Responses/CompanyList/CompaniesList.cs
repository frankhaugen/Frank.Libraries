using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Responses.CompanyList;

public class CompaniesList
{
    [JsonProperty("_embedded")] public Embedded? Data { get; set; }

    [JsonProperty("_links")] public Links? Links { get; set; }

    [JsonProperty("page")] public Page? Page { get; set; }
}