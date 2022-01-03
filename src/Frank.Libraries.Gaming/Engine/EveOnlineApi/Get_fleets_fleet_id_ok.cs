namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fleets_fleet_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fleets_fleet_id_ok(bool @is_free_move, bool @is_registered, bool @is_voice_enabled, string @motd)

        {

            this.Is_free_move = @is_free_move;

            this.Is_registered = @is_registered;

            this.Is_voice_enabled = @is_voice_enabled;

            this.Motd = @motd;

        }    /// <summary>
        /// Is free-move enabled
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_free_move")]
        public bool Is_free_move { get; init; }

        /// <summary>
        /// Does the fleet have an active fleet advertisement
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_registered")]
        public bool Is_registered { get; init; }

        /// <summary>
        /// Is EVE Voice enabled
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_voice_enabled")]
        public bool Is_voice_enabled { get; init; }

        /// <summary>
        /// Fleet MOTD in CCP flavoured HTML
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("motd")]
        public string Motd { get; init; }

    }
