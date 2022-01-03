namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_standings_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_standings_200_ok(int @from_id, Get_characters_character_id_standings_200_okFrom_type @from_type, float @standing)

        {

            this.From_id = @from_id;

            this.From_type = @from_type;

            this.Standing = @standing;

        }    /// <summary>
        /// from_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("from_id")]
        public int From_id { get; init; }

        /// <summary>
        /// from_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("from_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_standings_200_okFrom_type From_type { get; init; }

        /// <summary>
        /// standing number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("standing")]
        public float Standing { get; init; }

    }
