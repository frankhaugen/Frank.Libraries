using System.Text.Json.Serialization;

namespace Frank.Libraries.Gaming.Starfinder.Models.Generated{ 

    public class Port
    {
        [JsonPropertyName("weaponId")]
        public string WeaponId { get; set; }

        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        [JsonPropertyName("templateWeight")]
        public string TemplateWeight { get; set; }

        [JsonPropertyName("isFromTemplate")]
        public bool IsFromTemplate { get; set; }

        [JsonPropertyName("canBeLinked")]
        public bool CanBeLinked { get; set; }

        [JsonPropertyName("isLinked")]
        public bool IsLinked { get; set; }

        [JsonPropertyName("canHaveOrbitalDiscount")]
        public bool CanHaveOrbitalDiscount { get; set; }

        [JsonPropertyName("hasOrbitalDiscount")]
        public bool HasOrbitalDiscount { get; set; }

        [JsonPropertyName("specialMaterial")]
        public string SpecialMaterial { get; set; }
    }

}