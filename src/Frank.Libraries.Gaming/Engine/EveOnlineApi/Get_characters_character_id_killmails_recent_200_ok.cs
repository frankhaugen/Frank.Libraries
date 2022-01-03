namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_killmails_recent_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_killmails_recent_200_ok(string @killmail_hash, int @killmail_id)

        {

            this.Killmail_hash = @killmail_hash;

            this.Killmail_id = @killmail_id;

        }    /// <summary>
        /// A hash of this killmail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("killmail_hash")]
        public string Killmail_hash { get; init; }

        /// <summary>
        /// ID of this killmail
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("killmail_id")]
        public int Killmail_id { get; init; }

    }
