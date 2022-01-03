namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fw_stats_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fw_stats_200_ok(int @faction_id, Kills6 @kills, int @pilots, int @systems_controlled, Victory_points6 @victory_points)

        {

            this.Faction_id = @faction_id;

            this.Kills = @kills;

            this.Pilots = @pilots;

            this.Systems_controlled = @systems_controlled;

            this.Victory_points = @victory_points;

        }    /// <summary>
        /// faction_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("faction_id")]
        public int Faction_id { get; init; }

        /// <summary>
        /// Summary of kills against an enemy faction for the given faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("kills")]
        public Kills6 Kills { get; init; }

        /// <summary>
        /// How many pilots fight for the given faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("pilots")]
        public int Pilots { get; init; }

        /// <summary>
        /// The number of solar systems controlled by the given faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("systems_controlled")]
        public int Systems_controlled { get; init; }

        /// <summary>
        /// Summary of victory points gained for the given faction
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("victory_points")]
        public Victory_points6 Victory_points { get; init; }

    }
