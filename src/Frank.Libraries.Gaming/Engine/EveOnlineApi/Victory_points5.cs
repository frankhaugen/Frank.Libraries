using System.Collections.Generic;

namespace EveOnlineApi;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Victory_points5
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Victory_points5(IList<Active_total6> @active_total, IList<Last_week6> @last_week, IList<Yesterday6> @yesterday)

        {

            this.Active_total = @active_total;

            this.Last_week = @last_week;

            this.Yesterday = @yesterday;

        }    /// <summary>
        /// Top 10 ranking of corporations active in faction warfare by total victory points. A corporation is considered "active" if they have participated in faction warfare in the past 14 days
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("active_total")]
        public IList<Active_total6> Active_total { get; init; }

        /// <summary>
        /// Top 10 ranking of corporations by victory points in the past week
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("last_week")]
        public IList<Last_week6> Last_week { get; init; }

        /// <summary>
        /// Top 10 ranking of corporations by victory points in the past day
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("yesterday")]
        public IList<Yesterday6> Yesterday { get; init; }

    }
