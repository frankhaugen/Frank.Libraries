namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_characters_affiliation_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_characters_affiliation_200_ok(int? @alliance_id, int @character_id, int @corporation_id, int? @faction_id)

        {

            this.Alliance_id = @alliance_id;

            this.Character_id = @character_id;

            this.Corporation_id = @corporation_id;

            this.Faction_id = @faction_id;

        }    /// <summary>
        /// The character's alliance ID, if their corporation is in an alliance
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// The character's ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// The character's corporation ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// The character's faction ID, if their corporation is in a faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

    }
