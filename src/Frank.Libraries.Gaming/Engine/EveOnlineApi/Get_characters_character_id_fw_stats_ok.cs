namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_fw_stats_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_fw_stats_ok(int? @current_rank, System.DateTimeOffset? @enlisted_on, int? @faction_id, int? @highest_rank, Kills @kills, Victory_points @victory_points)

        {

            this.Current_rank = @current_rank;

            this.Enlisted_on = @enlisted_on;

            this.Faction_id = @faction_id;

            this.Highest_rank = @highest_rank;

            this.Kills = @kills;

            this.Victory_points = @victory_points;

        }    /// <summary>
        /// The given character's current faction rank
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("current_rank")]
        public int? Current_rank { get; init; }

        /// <summary>
        /// The enlistment date of the given character into faction warfare. Will not be included if character is not enlisted in faction warfare
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("enlisted_on")]
        public System.DateTimeOffset? Enlisted_on { get; init; }

        /// <summary>
        /// The faction the given character is enlisted to fight for. Will not be included if character is not enlisted in faction warfare
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int? Faction_id { get; init; }

        /// <summary>
        /// The given character's highest faction rank achieved
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("highest_rank")]
        public int? Highest_rank { get; init; }

        /// <summary>
        /// Summary of kills done by the given character against enemy factions
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("kills")]
        public Kills Kills { get; init; }

        /// <summary>
        /// Summary of victory points gained by the given character for the enlisted faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("victory_points")]
        public Victory_points Victory_points { get; init; }

    }
