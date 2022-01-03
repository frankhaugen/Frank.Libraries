using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_insurance_prices_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_insurance_prices_200_ok(IList<Levels> @levels, int @type_id)

        {

            this.Levels = @levels;

            this.Type_id = @type_id;

        }    /// <summary>
        /// A list of a available insurance levels for this ship type
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("levels")]
        public IList<Levels> Levels { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
