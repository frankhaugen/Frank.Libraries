namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_alliancehistory_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_alliancehistory_200_ok(int? @alliance_id, bool? @is_deleted, int @record_id, System.DateTimeOffset @start_date)

        {

            this.Alliance_id = @alliance_id;

            this.Is_deleted = @is_deleted;

            this.Record_id = @record_id;

            this.Start_date = @start_date;

        }    /// <summary>
        /// alliance_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("alliance_id")]
        public int? Alliance_id { get; init; }

        /// <summary>
        /// True if the alliance has been closed
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
