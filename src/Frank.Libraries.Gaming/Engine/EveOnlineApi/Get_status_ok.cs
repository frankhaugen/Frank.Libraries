namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_status_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_status_ok(int @players, string @server_version, System.DateTimeOffset @start_time, bool? @vip)

        {

            this.Players = @players;

            this.Server_version = @server_version;

            this.Start_time = @start_time;

            this.Vip = @vip;

        }    /// <summary>
        /// Current online player count
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("players")]
        public int Players { get; init; }

        /// <summary>
        /// Running version as string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("server_version")]
        public string Server_version { get; init; }

        /// <summary>
        /// Server start timestamp
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public System.DateTimeOffset Start_time { get; init; }

        /// <summary>
        /// If the server is in VIP mode
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("vip")]
        public bool? Vip { get; init; }

    }
