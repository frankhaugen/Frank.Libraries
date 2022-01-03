namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_containers_logs_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_containers_logs_200_ok(Get_corporations_corporation_id_containers_logs_200_okAction @action, int @character_id, long @container_id, int @container_type_id, Get_corporations_corporation_id_containers_logs_200_okLocation_flag @location_flag, long @location_id, System.DateTimeOffset @logged_at, int? @new_config_bitmask, int? @old_config_bitmask, Get_corporations_corporation_id_containers_logs_200_okPassword_type? @password_type, int? @quantity, int? @type_id)

        {

            this.Action = @action;

            this.Character_id = @character_id;

            this.Container_id = @container_id;

            this.Container_type_id = @container_type_id;

            this.Location_flag = @location_flag;

            this.Location_id = @location_id;

            this.Logged_at = @logged_at;

            this.New_config_bitmask = @new_config_bitmask;

            this.Old_config_bitmask = @old_config_bitmask;

            this.Password_type = @password_type;

            this.Quantity = @quantity;

            this.Type_id = @type_id;

        }    /// <summary>
        /// action string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("action")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_containers_logs_200_okAction Action { get; init; }

        /// <summary>
        /// ID of the character who performed the action.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("character_id")]
        public int Character_id { get; init; }

        /// <summary>
        /// ID of the container
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public long Container_id { get; init; }

        /// <summary>
        /// Type ID of the container
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("container_type_id")]
        public int Container_type_id { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_containers_logs_200_okLocation_flag Location_flag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// Timestamp when this log was created
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("logged_at")]
        public System.DateTimeOffset Logged_at { get; init; }

        /// <summary>
        /// new_config_bitmask integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("new_config_bitmask")]
        public int? New_config_bitmask { get; init; }

        /// <summary>
        /// old_config_bitmask integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("old_config_bitmask")]
        public int? Old_config_bitmask { get; init; }

        /// <summary>
        /// Type of password set if action is of type SetPassword or EnterPassword
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("password_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Get_corporations_corporation_id_containers_logs_200_okPassword_type? Password_type { get; init; }

        /// <summary>
        /// Quantity of the item being acted upon
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; init; }

        /// <summary>
        /// Type ID of the item being acted upon
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int? Type_id { get; init; }

    }
