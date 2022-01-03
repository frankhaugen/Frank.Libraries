namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_fatigue_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_fatigue_ok(System.DateTimeOffset? @jump_fatigue_expire_date, System.DateTimeOffset? @last_jump_date, System.DateTimeOffset? @last_update_date)

        {

            this.Jump_fatigue_expire_date = @jump_fatigue_expire_date;

            this.Last_jump_date = @last_jump_date;

            this.Last_update_date = @last_update_date;

        }    /// <summary>
        /// Character's jump fatigue expiry
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("jump_fatigue_expire_date")]
        public System.DateTimeOffset? Jump_fatigue_expire_date { get; init; }

        /// <summary>
        /// Character's last jump activation
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_jump_date")]
        public System.DateTimeOffset? Last_jump_date { get; init; }

        /// <summary>
        /// Character's last jump update
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_update_date")]
        public System.DateTimeOffset? Last_update_date { get; init; }

    }
