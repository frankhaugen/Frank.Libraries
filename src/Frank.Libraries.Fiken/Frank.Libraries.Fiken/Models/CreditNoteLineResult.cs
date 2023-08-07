using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class CreditNoteLineResult
{
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
    ///     One of: {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\",
    ///     \"NONE\"}. \"HIGH\" is the most common. Example: High
    /// </summary>
    /// <value>
    ///     One of: {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\",
    ///     \"NONE\"}. \"HIGH\" is the most common. Example: High
    /// </value>
    [DataMember(Name = "vatType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatType")]
    public string VatType { get; set; }

    /// <summary>
    ///     Net price per unit in invoice currency (in cents).
    /// </summary>
    /// <value>Net price per unit in invoice currency (in cents).</value>
    [DataMember(Name = "unitPrice", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "unitPrice")]
    public long? UnitPrice { get; set; }

    /// <summary>
    ///     Number of units to be invoiced.
    /// </summary>
    /// <value>Number of units to be invoiced.</value>
    [DataMember(Name = "quantity", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    ///     If field is set, all amounts must be given before the discount is applied. The API will calculate the new totals.
    ///     Discount value should be a percent with a value between 0 and 100. Decimal values such as 25.5 are also allowed.
    /// </summary>
    /// <value>
    ///     If field is set, all amounts must be given before the discount is applied. The API will calculate the new
    ///     totals. Discount value should be a percent with a value between 0 and 100. Decimal values such as 25.5 are also
    ///     allowed.
    /// </value>
    [DataMember(Name = "discount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "discount")]
    public decimal? Discount { get; set; }

    /// <summary>
    ///     Product Id of product associated with invoice line.
    /// </summary>
    /// <value>Product Id of product associated with invoice line.</value>
    [DataMember(Name = "productId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "productId")]
    public long? ProductId { get; set; }

    /// <summary>
    ///     Description of the invoiced product or service.
    /// </summary>
    /// <value>Description of the invoiced product or service.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    ///     Additional information to be printed on invoice.
    /// </summary>
    /// <value>Additional information to be printed on invoice.</value>
    [DataMember(Name = "comment", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreditNoteLineResult {\n");
        sb.Append("  IncomeAccount: ")
          .Append(IncomeAccount)
          .Append("\n");
        sb.Append("  VatType: ")
          .Append(VatType)
          .Append("\n");
        sb.Append("  UnitPrice: ")
          .Append(UnitPrice)
          .Append("\n");
        sb.Append("  Quantity: ")
          .Append(Quantity)
          .Append("\n");
        sb.Append("  Discount: ")
          .Append(Discount)
          .Append("\n");
        sb.Append("  ProductId: ")
          .Append(ProductId)
          .Append("\n");
        sb.Append("  Description: ")
          .Append(Description)
          .Append("\n");
        sb.Append("  Comment: ")
          .Append(Comment)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}