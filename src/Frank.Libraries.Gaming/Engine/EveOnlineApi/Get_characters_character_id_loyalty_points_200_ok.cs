namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_loyalty_points_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_loyalty_points_200_ok(int @corporation_id, int @loyalty_points)

        {

            this.Corporation_id = @corporation_id;

            this.Loyalty_points = @loyalty_points;

        }    /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// loyalty_points integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("loyalty_points")]
        public int Loyalty_points { get; init; }

    }
