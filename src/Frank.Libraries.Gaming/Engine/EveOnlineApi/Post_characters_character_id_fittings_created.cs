namespace EveOnlineApi;

    /// <summary>
    /// 201 created object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_characters_character_id_fittings_created
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_characters_character_id_fittings_created(int @fitting_id)

        {

            this.Fitting_id = @fitting_id;

        }    /// <summary>
        /// fitting_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("fitting_id")]
        public int Fitting_id { get; init; }

    }
