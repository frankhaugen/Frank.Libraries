namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_facilities_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_facilities_200_ok(long @facility_id, int @system_id, int @type_id)

        {

            this.Facility_id = @facility_id;

            this.System_id = @system_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// facility_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("facility_id")]
        public long Facility_id { get; init; }

        /// <summary>
        /// system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
