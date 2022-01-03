namespace EveOnlineApi;

    /// <summary>
    /// new_settings object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Put_fleets_fleet_id_new_settings
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Put_fleets_fleet_id_new_settings(bool? @is_free_move, string? @motd)

        {

            this.Is_free_move = @is_free_move;

            this.Motd = @motd;

        }    /// <summary>
        /// Should free-move be enabled in the fleet
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_free_move")]
        public bool? Is_free_move { get; init; }

        /// <summary>
        /// New fleet MOTD in CCP flavoured HTML
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("motd")]
        public string? Motd { get; init; }

    }
