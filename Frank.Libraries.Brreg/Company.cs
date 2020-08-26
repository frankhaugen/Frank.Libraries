using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Frank.Libraries.Brreg
{
    public class Company
    {
        [JsonProperty("organisasjonsnummer")]
        public long Organisasjonsnummer { get; set; }

        [JsonProperty("navn")]
        public string? Navn { get; set; }

        [JsonProperty("organisasjonsform")]
        public Organisasjonsform? Organisasjonsform { get; set; }

        [JsonProperty("postadresse")]
        public Postadresse? Postadresse { get; set; }

        [JsonProperty("registreringsdatoEnhetsregisteret")]
        public DateTimeOffset RegistreringsdatoEnhetsregisteret { get; set; }

        [JsonProperty("registrertIMvaregisteret")]
        public bool RegistrertIMvaregisteret { get; set; }

        [JsonProperty("naeringskode1")]
        public Naeringskode1? Naeringskode1 { get; set; }

        [JsonProperty("antallAnsatte")]
        public long AntallAnsatte { get; set; }

        [JsonProperty("forretningsadresse")]
        public Forretningsadresse? Forretningsadresse { get; set; }

        [JsonProperty("stiftelsesdato")]
        public DateTimeOffset Stiftelsesdato { get; set; }

        [JsonProperty("registrertIForetaksregisteret")]
        public bool RegistrertIForetaksregisteret { get; set; }

        [JsonProperty("registrertIStiftelsesregisteret")]
        public bool RegistrertIStiftelsesregisteret { get; set; }

        [JsonProperty("registrertIFrivillighetsregisteret")]
        public bool RegistrertIFrivillighetsregisteret { get; set; }

        [JsonProperty("konkurs")]
        public bool Konkurs { get; set; }

        [JsonProperty("underAvvikling")]
        public bool UnderAvvikling { get; set; }

        [JsonProperty("underTvangsavviklingEllerTvangsopplosning")]
        public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }

        [JsonProperty("maalform")]
        public string? Maalform { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }
    }

    public partial class Forretningsadresse
    {
        [JsonProperty("land")]
        public string? Land { get; set; }

        [JsonProperty("landkode")]
        public string? Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string? Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string? Poststed { get; set; }

        [JsonProperty("adresse")]
        public List<string>? Adresse { get; set; }

        [JsonProperty("kommune")]
        public string? Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string? Kommunenummer { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Self? Self { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public Uri? Href { get; set; }
    }

    public partial class Naeringskode1
    {
        [JsonProperty("beskrivelse")]
        public string? Beskrivelse { get; set; }

        [JsonProperty("kode")]
        public string? Kode { get; set; }
    }

    public partial class Organisasjonsform
    {
        [JsonProperty("kode")]
        public string? Kode { get; set; }

        [JsonProperty("beskrivelse")]
        public string? Beskrivelse { get; set; }

        [JsonProperty("_links")]
        public Links? Links { get; set; }
    }

    public partial class Postadresse
    {
        [JsonProperty("land")]
        public string? Land { get; set; }

        [JsonProperty("landkode")]
        public string? Landkode { get; set; }

        [JsonProperty("postnummer")]
        public string? Postnummer { get; set; }

        [JsonProperty("poststed")]
        public string? Poststed { get; set; }

        [JsonProperty("adresse")]
        public List<string>? Adresse { get; set; }

        [JsonProperty("kommune")]
        public string? Kommune { get; set; }

        [JsonProperty("kommunenummer")]
        public string? Kommunenummer { get; set; }
    }
}
