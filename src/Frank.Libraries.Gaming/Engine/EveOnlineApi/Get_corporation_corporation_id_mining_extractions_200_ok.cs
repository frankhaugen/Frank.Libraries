namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporation_corporation_id_mining_extractions_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporation_corporation_id_mining_extractions_200_ok(System.DateTimeOffset @chunk_arrival_time, System.DateTimeOffset @extraction_start_time, int @moon_id, System.DateTimeOffset @natural_decay_time, long @structure_id)

        {

            this.Chunk_arrival_time = @chunk_arrival_time;

            this.Extraction_start_time = @extraction_start_time;

            this.Moon_id = @moon_id;

            this.Natural_decay_time = @natural_decay_time;

            this.Structure_id = @structure_id;

        }    /// <summary>
        /// The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("chunk_arrival_time")]
        public System.DateTimeOffset Chunk_arrival_time { get; init; }

        /// <summary>
        /// The time at which the current extraction was initiated.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("extraction_start_time")]
        public System.DateTimeOffset Extraction_start_time { get; init; }

        /// <summary>
        /// moon_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("moon_id")]
        public int Moon_id { get; init; }

        /// <summary>
        /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("natural_decay_time")]
        public System.DateTimeOffset Natural_decay_time { get; init; }

        /// <summary>
        /// structure_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("structure_id")]
        public long Structure_id { get; init; }

    }
