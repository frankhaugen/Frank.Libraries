using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Company
{
    public class Variant
    {
        [JsonProperty("kode")]
        public string? Code { get; set; }

        [JsonProperty("beskrivelse")]
        public string? Description { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }
    }
}
