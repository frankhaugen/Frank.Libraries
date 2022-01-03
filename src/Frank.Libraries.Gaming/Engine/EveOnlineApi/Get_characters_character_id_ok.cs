namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_ok(int? @alliance_id, System.DateTimeOffset @birthday, int @bloodline_id, int @corporation_id, string? @description, int? @faction_id, Get_characters_character_id_okGender @gender, string @name, int @race_id, float? @security_status, string? @title)

        {

            this.Alliance_id = @alliance_id;

            this.Birthday = @birthday;

            this.Bloodline_id = @bloodline_id;

            this.Corporation_id = @corporation_id;

            this.Description = @description;

            this.Faction_id = @faction_id;

            this.Gender = @gender;

            this.Name = @name;

            this.Race_id = @race_id;

            this.Security_status = @security_status;

            this.Title = @title;

        }    /// <summary>
        /// The character's alliance ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// Creation date of the character
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("birthday")]
        public System.DateTimeOffset Birthday { get; init; }

        /// <summary>
        /// bloodline_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("bloodline_id")]
        public int Bloodline_id { get; init; }

        /// <summary>
        /// The character's corporation ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// ID of the faction the character is fighting for, if the character is enlisted in Factional Warfare
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// gender string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("gender")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_characters_character_id_okGender Gender { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("race_id")]
        public int Race_id { get; init; }

        /// <summary>
        /// security_status number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("security_status")]
        public float? Security_status { get; init; }

        /// <summary>
        /// The individual title of the character
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

    }
