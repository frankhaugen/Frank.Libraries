namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporation_corporation_id_mining_observers_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporation_corporation_id_mining_observers_200_ok(System.DateTimeOffset @last_updated, long @observer_id, Get_corporation_corporation_id_mining_observers_200_okObserver_type @observer_type)

        {

            this.Last_updated = @last_updated;

            this.Observer_id = @observer_id;

            this.Observer_type = @observer_type;

        }    /// <summary>
        /// last_updated string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_updated")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset Last_updated { get; init; }

        /// <summary>
        /// The entity that was observing the asteroid field when it was mined.
        /// <br/>
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("observer_id")]
        public long Observer_id { get; init; }

        /// <summary>
        /// The category of the observing entity
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("observer_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporation_corporation_id_mining_observers_200_okObserver_type Observer_type { get; init; }

    }
