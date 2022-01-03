namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_mail_lists_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_mail_lists_200_ok(int @mailing_list_id, string @name)

        {

            this.Mailing_list_id = @mailing_list_id;

            this.Name = @name;

        }    /// <summary>
        /// Mailing list ID
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("mailing_list_id")]
        public int Mailing_list_id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }
