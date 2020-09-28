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

    public class Embedded
    {
        [JsonProperty("enheter")]
        public List<Company>? Companies { get; set; }
    }

    public class First
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Self3
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Next
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Last
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class Links3
    {
        [JsonProperty("first")]
        public First? First { get; set; }

        [JsonProperty("self")]
        public Self3? Self { get; set; }

        [JsonProperty("next")]
        public Next? Next { get; set; }

        [JsonProperty("last")]
        public Last? Last { get; set; }
    }

    public class Page
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class CompaniesList
    {
        [JsonProperty("_embedded")]
        public Embedded? Data { get; set; }

        [JsonProperty("_links")]
        public Links3? Links { get; set; }

        [JsonProperty("page")]
        public Page? Page { get; set; }
    }
}
