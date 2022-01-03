namespace EveOnlineApi;

    /// <summary>
    /// 201 created object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Post_fleets_fleet_id_wings_wing_id_squads_created
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Post_fleets_fleet_id_wings_wing_id_squads_created(long @squad_id)

        {

            this.Squad_id = @squad_id;

        }    /// <summary>
        /// The squad_id of the newly created squad
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("squad_id")]
        public long Squad_id { get; init; }

    }
