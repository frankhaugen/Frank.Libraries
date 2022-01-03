using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_fleets_fleet_id_wings_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_fleets_fleet_id_wings_200_ok(long @id, string @name, IList<Squads> @squads)

        {

            this.Id = @id;

            this.Name = @name;

            this.Squads = @squads;

        }    /// <summary>
        /// id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// squads array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("squads")]
        public IList<Squads> Squads { get; init; }

    }
