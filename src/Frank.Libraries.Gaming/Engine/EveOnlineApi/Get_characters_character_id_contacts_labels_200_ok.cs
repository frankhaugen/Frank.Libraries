namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_contacts_labels_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_contacts_labels_200_ok(long @label_id, string @label_name)

        {

            this.Label_id = @label_id;

            this.Label_name = @label_name;

        }    /// <summary>
        /// label_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("label_id")]
        public long Label_id { get; init; }

        /// <summary>
        /// label_name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("label_name")]
        public string Label_name { get; init; }

    }
