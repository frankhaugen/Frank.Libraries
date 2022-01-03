namespace EveOnlineApi;

    /// <summary>
    /// naming object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Put_fleets_fleet_id_squads_squad_id_naming
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Put_fleets_fleet_id_squads_squad_id_naming(string @name)

        {

            this.Name = @name;

        }    /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

    }
