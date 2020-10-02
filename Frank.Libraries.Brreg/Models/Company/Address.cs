using Newtonsoft.Json;
using System.Collections.Generic;

namespace Frank.Libraries.Brreg.Models.Company
{
    public class Address
    {
        [JsonProperty("land")]
        public string? Country { get; set; }

        [JsonProperty("landkode")]
        public string? CountryCode { get; set; }

        [JsonProperty("postnummer")]
        public string? ZipCode { get; set; }

        [JsonProperty("poststed")]
        public string? City { get; set; }

        [JsonProperty("adresse")]
        public List<string>? Street { get; set; }

        [JsonProperty("kommune")]
        public string? Municipality { get; set; }

        [JsonProperty("kommunenummer")]
        public string? MunicipalityNumber { get; set; }
    }
}
