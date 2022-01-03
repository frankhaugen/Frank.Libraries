using System.Collections.Generic;

namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_loyalty_stores_corporation_id_offers_200_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_loyalty_stores_corporation_id_offers_200_ok(int? @ak_cost, long @isk_cost, int @lp_cost, int @offer_id, int @quantity, IList<Required_items> @required_items, int @type_id)

        {

            this.Ak_cost = @ak_cost;

            this.Isk_cost = @isk_cost;

            this.Lp_cost = @lp_cost;

            this.Offer_id = @offer_id;

            this.Quantity = @quantity;

            this.Required_items = @required_items;

            this.Type_id = @type_id;

        }    /// <summary>
        /// Analysis kredit cost
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ak_cost")]
        public int? Ak_cost { get; init; }

        /// <summary>
        /// isk_cost integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("isk_cost")]
        public long Isk_cost { get; init; }

        /// <summary>
        /// lp_cost integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("lp_cost")]
        public int Lp_cost { get; init; }

        /// <summary>
        /// offer_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("offer_id")]
        public int Offer_id { get; init; }

        /// <summary>
        /// quantity integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int Quantity { get; init; }

        /// <summary>
        /// required_items array
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("required_items")]
        public IList<Required_items> Required_items { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int Type_id { get; init; }

    }
