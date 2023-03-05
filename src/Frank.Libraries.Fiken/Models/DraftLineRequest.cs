using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class DraftLineRequest
{
    /// <summary>
    ///     Description of the sale/purchase line.
    /// </summary>
    /// <value>Description of the sale/purchase line.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    ///     Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse] Vat
    ///     Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis,
    ///     medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible,
    ///     medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible,
    ///     high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible,
    ///     high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]
    /// </summary>
    /// <value>
    ///     Vat Types for SALES: [none, high, medium, raw_fish, low, exempt_import_export, exempt, outside, exempt_reverse]
    ///     Vat Types for PURCHASES: [none, high, medium, raw_fish, low, exempt_import_export, high_direct, high_basis,
    ///     medium_direct, medium_basis, none_import_basis, high_import_deductible, high_import_nondeductible,
    ///     medium_import_deductible, medium_import_nondeductible, high_foreign_service_deductible,
    ///     high_foreign_service_nondeductible, low_foreign_service_deductible, low_foreign_service_nondeductible,
    ///     high_purchase_of_emissionstrading_or_gold_deductible, high_purchase_of_emissionstrading_or_gold_nondeductible]
    /// </value>
    [DataMember(Name = "vatType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatType")]
    public string VatType { get; set; }

    /// <summary>
    ///     Field is similar to vatType, it defaults to the product's income account. Either the line or the product needs to
    ///     have an income account set.
    /// </summary>
    /// <value>
    ///     Field is similar to vatType, it defaults to the product's income account. Either the line or the product needs
    ///     to have an income account set.
    /// </value>
    [DataMember(Name = "incomeAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "incomeAccount")]
    public string IncomeAccount { get; set; }

    /// <summary>
    ///     Net amount (in creditNote currency) in cents.
    /// </summary>
    /// <value>Net amount (in creditNote currency) in cents.</value>
    [DataMember(Name = "net", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "net")]
    public long? Net { get; set; }

    /// <summary>
    ///     Gross amount (= net+VAT) (in creditNote currency) in cents.
    /// </summary>
    /// <value>Gross amount (= net+VAT) (in creditNote currency) in cents.</value>
    [DataMember(Name = "gross", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "gross")]
    public long? Gross { get; set; }

    /// <summary>
    ///     Gets or Sets ProjectId
    /// </summary>
    [DataMember(Name = "projectId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "projectId")]
    public long? ProjectId { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DraftLineRequest {\n");
        sb.Append("  Text: ")
          .Append(Text)
          .Append("\n");
        sb.Append("  VatType: ")
          .Append(VatType)
          .Append("\n");
        sb.Append("  IncomeAccount: ")
          .Append(IncomeAccount)
          .Append("\n");
        sb.Append("  Net: ")
          .Append(Net)
          .Append("\n");
        sb.Append("  Gross: ")
          .Append(Gross)
          .Append("\n");
        sb.Append("  ProjectId: ")
          .Append(ProjectId)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}