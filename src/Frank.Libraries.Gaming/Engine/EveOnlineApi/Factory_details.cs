namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Factory_details
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Factory_details(int @schematic_id)

        {

            this.Schematic_id = @schematic_id;

        }    /// <summary>
        /// schematic_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("schematic_id")]
        public int Schematic_id { get; init; }

    }
