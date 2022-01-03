namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_online_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_online_ok(System.DateTimeOffset? @last_login, System.DateTimeOffset? @last_logout, int? @logins, bool @online)

        {

            this.Last_login = @last_login;

            this.Last_logout = @last_logout;

            this.Logins = @logins;

            this.Online = @online;

        }    /// <summary>
        /// Timestamp of the last login
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_login")]
        public System.DateTimeOffset? Last_login { get; init; }

        /// <summary>
        /// Timestamp of the last logout
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_logout")]
        public System.DateTimeOffset? Last_logout { get; init; }

        /// <summary>
        /// Total number of times the character has logged in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("logins")]
        public int? Logins { get; init; }

        /// <summary>
        /// If the character is online
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("online")]
        public bool Online { get; init; }

    }
