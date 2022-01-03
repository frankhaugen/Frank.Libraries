namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_icons_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_icons_ok(string? @px128x128, string? @px256x256, string? @px64x64)

        {

            this.Px128x128 = @px128x128;

            this.Px256x256 = @px256x256;

            this.Px64x64 = @px64x64;

        }    /// <summary>
        /// px128x128 string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("px128x128")]
        public string? Px128x128 { get; init; }

        /// <summary>
        /// px256x256 string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("px256x256")]
        public string? Px256x256 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("px64x64")]
        public string? Px64x64 { get; init; }

    }
