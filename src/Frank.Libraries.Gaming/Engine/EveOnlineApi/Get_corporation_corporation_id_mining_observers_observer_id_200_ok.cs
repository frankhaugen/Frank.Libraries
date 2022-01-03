namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporation_corporation_id_mining_observers_observer_id_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporation_corporation_id_mining_observers_observer_id_200_ok(int @character_id, System.DateTimeOffset @last_updated, long @quantity, int @recorded_corporation_id, int @type_id)

        {

            this.Character_id = @character_id;

            this.Last_updated = @last_updated;

            this.Quantity = @quantity;

            this.Recorded_corporation_id = @recorded_corporation_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// The character that did the mining
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// last_updated string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Last_updated { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public long Quantity { get; init; }

        /// <summary>
        /// The corporation id of the character at the time data was recorded.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("recorded_corporation_id")]
        public int Recorded_corporation_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
