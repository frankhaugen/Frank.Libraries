using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_stations_station_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_stations_station_id_ok(float @max_dockable_ship_volume, string @name, float @office_rental_cost, int? @owner, Position6 @position, int? @race_id, float @reprocessing_efficiency, float @reprocessing_stations_take, IList<Services2> @services, int @station_id, int @system_id, int @type_id)

        {

            this.Max_dockable_ship_volume = @max_dockable_ship_volume;

            this.Name = @name;

            this.Office_rental_cost = @office_rental_cost;

            this.Owner = @owner;

            this.Position = @position;

            this.Race_id = @race_id;

            this.Reprocessing_efficiency = @reprocessing_efficiency;

            this.Reprocessing_stations_take = @reprocessing_stations_take;

            this.Services = @services;

            this.Station_id = @station_id;

            this.System_id = @system_id;

            this.Type_id = @type_id;

        }    /// <summary>
        /// max_dockable_ship_volume number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("max_dockable_ship_volume")]
        public float Max_dockable_ship_volume { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// office_rental_cost number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("office_rental_cost")]
        public float Office_rental_cost { get; init; }

        /// <summary>
        /// ID of the corporation that controls this station
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("owner")]
        public int? Owner { get; init; }

        /// <summary>
        /// position object
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public Position6 Position { get; init; }

        /// <summary>
        /// race_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("race_id")]
        public int? Race_id { get; init; }

        /// <summary>
        /// reprocessing_efficiency number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reprocessing_efficiency")]
        public float Reprocessing_efficiency { get; init; }

        /// <summary>
        /// reprocessing_stations_take number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("reprocessing_stations_take")]
        public float Reprocessing_stations_take { get; init; }

        /// <summary>
        /// services array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("services")]

        // (system.text.json): Add string enum item converter
        public IList<Services2> Services { get; init; }

        /// <summary>
        /// station_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("station_id")]
        public int Station_id { get; init; }

        /// <summary>
        /// The solar system this station is in
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("system_id")]
        public int System_id { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
