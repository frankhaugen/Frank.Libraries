using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_universe_regions_region_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_universe_regions_region_id_ok(IList<int> @constellations, string? @description, string @name, int @region_id)

        {

            this.Constellations = @constellations;

            this.Description = @description;

            this.Name = @name;

            this.Region_id = @region_id;

        }    /// <summary>
        /// constellations array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("constellations")]
        public IList<int> Constellations { get; init; }

        /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// region_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public int Region_id { get; init; }

    }
