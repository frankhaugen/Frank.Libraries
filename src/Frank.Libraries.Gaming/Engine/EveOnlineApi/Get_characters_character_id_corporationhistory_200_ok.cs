namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_corporationhistory_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_corporationhistory_200_ok(int @corporation_id, bool? @is_deleted, int @record_id, System.DateTimeOffset @start_date)

        {

            this.Corporation_id = @corporation_id;

            this.Is_deleted = @is_deleted;

            this.Record_id = @record_id;

            this.Start_date = @start_date;

        }    /// <summary>
        /// corporation_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("corporation_id")]
        public int Corporation_id { get; init; }

        /// <summary>
        /// True if the corporation has been deleted
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        public bool? Is_deleted { get; init; }

        /// <summary>
        /// An incrementing ID that can be used to canonically establish order of records in cases where dates may be ambiguous
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
        public int Record_id { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public System.DateTimeOffset Start_date { get; init; }

    }
