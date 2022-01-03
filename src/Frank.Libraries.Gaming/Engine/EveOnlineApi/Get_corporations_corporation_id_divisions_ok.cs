using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_corporations_corporation_id_divisions_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_corporations_corporation_id_divisions_ok(IList<Hangar>? @hangar, IList<Wallet>? @wallet)

        {

            this.Hangar = @hangar;

            this.Wallet = @wallet;

        }    /// <summary>
        /// hangar array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("hangar")]
        public IList<Hangar>? Hangar { get; init; }

        /// <summary>
        /// wallet array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("wallet")]
        public IList<Wallet>? Wallet { get; init; }

    }
