namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_medals_issued_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_medals_issued_200_ok(int @character_id, System.DateTimeOffset @issued_at, int @issuer_id, int @medal_id, string @reason, Get_corporations_corporation_id_medals_issued_200_okStatus @status)

        {

            this.Character_id = @character_id;

            this.Issued_at = @issued_at;

            this.Issuer_id = @issuer_id;

            this.Medal_id = @medal_id;

            this.Reason = @reason;

            this.Status = @status;

        }    /// <summary>
        /// ID of the character who was rewarded this medal
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// issued_at string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issued_at")]
        public System.DateTimeOffset Issued_at { get; init; }

        /// <summary>
        /// ID of the character who issued the medal
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("issuer_id")]
        public int Issuer_id { get; init; }

        /// <summary>
        /// medal_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("medal_id")]
        public int Medal_id { get; init; }

        /// <summary>
        /// reason string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; init; }

        /// <summary>
        /// status string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_medals_issued_200_okStatus Status { get; init; }

    }
