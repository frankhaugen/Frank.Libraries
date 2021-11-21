using System;
using Newtonsoft.Json;

namespace Frank.Libraries.Brreg.Models.Company
{
    public class Company
    {
        [JsonProperty("organisasjonsnummer")] public long RegistrationNumber { get; set; }

        [JsonProperty("antallAnsatte")] public long Employees { get; set; }

        [JsonProperty("navn")] public string? Name { get; set; }

        [JsonProperty("maalform")] public string? Language { get; set; }

        [JsonProperty("registrertIForetaksregisteret")]
        public bool InCompanyRegistry { get; set; }

        [JsonProperty("registrertIStiftelsesregisteret")]
        public bool InTrustRegistry { get; set; }

        [JsonProperty("registrertIFrivillighetsregisteret")]
        public bool InNgoRegistry { get; set; }

        [JsonProperty("konkurs")] public bool IsBankrupt { get; set; }

        [JsonProperty("underAvvikling")] public bool IsUnderLiquidation { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool InVatRegistry { get; set; }

        [JsonProperty("underTvangsavviklingEllerTvangsopplosning")]
        public bool IsUnderForcedLiquidation { get; set; }

        [JsonProperty("stiftelsesdato")] public DateTimeOffset CreationDate { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public DateTimeOffset RegistrationDate { get; set; }

        [JsonProperty("organisasjonsform")] public Variant? Variant { get; set; }

        [JsonProperty("postadresse")] public Address? PostalAddress { get; set; }

        [JsonProperty("naeringskode1")] public BusinessArea? BusinessArea { get; set; }

        [JsonProperty("forretningsadresse")] public Address? BusinessAddress { get; set; }

        [JsonProperty("_links")] public Links? Links { get; set; }
    }
}