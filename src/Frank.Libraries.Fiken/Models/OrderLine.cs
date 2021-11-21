using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class OrderLine
    {
        /// <summary>
        /// Description of the product or service.
        /// </summary>
        /// <value>Description of the product or service.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Net amount of order line in cents.
        /// </summary>
        /// <value>Net amount of order line in cents.</value>
        [DataMember(Name = "netPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "netPrice")]
        public long? NetPrice { get; set; }

        /// <summary>
        /// VAT amount of order line in cents.
        /// </summary>
        /// <value>VAT amount of order line in cents.</value>
        [DataMember(Name = "vat", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vat")]
        public long? Vat { get; set; }

        /// <summary>
        /// Expense account (kostnadskonto) associated with payment.
        /// </summary>
        /// <value>Expense account (kostnadskonto) associated with payment.</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        /// <summary>
        /// Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis, medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible, medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible, high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible, high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]
        /// </summary>
        /// <value>Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis, medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible, medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible, high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible, high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible] </value>
        [DataMember(Name = "vatType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatType")]
        public string VatType { get; set; }

        /// <summary>
        /// Net amount in currency (in cents)
        /// </summary>
        /// <value>Net amount in currency (in cents)</value>
        [DataMember(Name = "netPriceInCurrency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "netPriceInCurrency")]
        public long? NetPriceInCurrency { get; set; }

        /// <summary>
        /// VAT amount in currency (in cents)
        /// </summary>
        /// <value>VAT amount in currency (in cents)</value>
        [DataMember(Name = "vatInCurrency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatInCurrency")]
        public long? VatInCurrency { get; set; }

        /// <summary>
        /// If a purchase is split over several projects, project/line can be specified. This field is only to be used for purchases.
        /// </summary>
        /// <value>If a purchase is split over several projects, project/line can be specified. This field is only to be used for purchases.</value>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projectId")]
        public long? ProjectId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLine {\n");
            sb.Append("  Description: ")
              .Append(Description)
              .Append("\n");
            sb.Append("  NetPrice: ")
              .Append(NetPrice)
              .Append("\n");
            sb.Append("  Vat: ")
              .Append(Vat)
              .Append("\n");
            sb.Append("  Account: ")
              .Append(Account)
              .Append("\n");
            sb.Append("  VatType: ")
              .Append(VatType)
              .Append("\n");
            sb.Append("  NetPriceInCurrency: ")
              .Append(NetPriceInCurrency)
              .Append("\n");
            sb.Append("  VatInCurrency: ")
              .Append(VatInCurrency)
              .Append("\n");
            sb.Append("  ProjectId: ")
              .Append(ProjectId)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}