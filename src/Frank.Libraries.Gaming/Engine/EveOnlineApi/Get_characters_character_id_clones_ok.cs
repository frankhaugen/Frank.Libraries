using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_characters_character_id_clones_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_characters_character_id_clones_ok(Home_location? @home_location, IList<Jump_clones> @jump_clones, System.DateTimeOffset? @last_clone_jump_date, System.DateTimeOffset? @last_station_change_date)

        {

            this.Home_location = @home_location;

            this.Jump_clones = @jump_clones;

            this.Last_clone_jump_date = @last_clone_jump_date;

            this.Last_station_change_date = @last_station_change_date;

        }    /// <summary>
        /// home_location object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("home_location")]
        public Home_location? Home_location { get; init; }

        /// <summary>
        /// jump_clones array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("jump_clones")]
        public IList<Jump_clones> Jump_clones { get; init; }

        /// <summary>
        /// last_clone_jump_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_clone_jump_date")]
        public System.DateTimeOffset? Last_clone_jump_date { get; init; }

        /// <summary>
        /// last_station_change_date string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_station_change_date")]
        public System.DateTimeOffset? Last_station_change_date { get; init; }

    }
