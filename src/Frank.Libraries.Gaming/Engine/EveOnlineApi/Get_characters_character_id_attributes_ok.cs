namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_attributes_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_attributes_ok(System.DateTimeOffset? @accrued_remap_cooldown_date, int? @bonus_remaps, int @charisma, int @intelligence, System.DateTimeOffset? @last_remap_date, int @memory, int @perception, int @willpower)

        {

            this.Accrued_remap_cooldown_date = @accrued_remap_cooldown_date;

            this.Bonus_remaps = @bonus_remaps;

            this.Charisma = @charisma;

            this.Intelligence = @intelligence;

            this.Last_remap_date = @last_remap_date;

            this.Memory = @memory;

            this.Perception = @perception;

            this.Willpower = @willpower;

        }    /// <summary>
        /// Neural remapping cooldown after a character uses remap accrued over time
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("accrued_remap_cooldown_date")]
        public System.DateTimeOffset? Accrued_remap_cooldown_date { get; init; }

        /// <summary>
        /// Number of available bonus character neural remaps
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bonus_remaps")]
        public int? Bonus_remaps { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("charisma")]
        public int Charisma { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("intelligence")]
        public int Intelligence { get; init; }

        /// <summary>
        /// Datetime of last neural remap, including usage of bonus remaps
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_remap_date")]
        public System.DateTimeOffset? Last_remap_date { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("memory")]
        public int Memory { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("perception")]
        public int Perception { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("willpower")]
        public int Willpower { get; init; }

    }
