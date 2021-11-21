using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Company
{
    public class BusinessArea
    {
        [JsonProperty("beskrivelse")] public string? Description { get; set; }

        [JsonProperty("kode")] public string? Code { get; set; }
    }
}