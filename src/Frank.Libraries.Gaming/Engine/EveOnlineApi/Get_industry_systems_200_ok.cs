using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_industry_systems_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_industry_systems_200_ok(IList<Cost_indices> @cost_indices, int @solar_system_id)

        {

            this.Cost_indices = @cost_indices;

            this.Solar_system_id = @solar_system_id;

        }    /// <summary>
        /// cost_indices array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("cost_indices")]
        public IList<Cost_indices> Cost_indices { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("solar_system_id")]
        public int Solar_system_id { get; init; }

    }
