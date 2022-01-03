using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// jump_clone object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Jump_clones
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Jump_clones(IList<int> @implants, int @jump_clone_id, long @location_id, Jump_clonesLocation_type @location_type, string? @name)

        {

            this.Implants = @implants;

            this.Jump_clone_id = @jump_clone_id;

            this.Location_id = @location_id;

            this.Location_type = @location_type;

            this.Name = @name;

        }    /// <summary>
        /// implants array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("implants")]
        public IList<int> Implants { get; init; }

        /// <summary>
        /// jump_clone_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("jump_clone_id")]
        public int Jump_clone_id { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public long Location_id { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("location_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Jump_clonesLocation_type Location_type { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

    }
