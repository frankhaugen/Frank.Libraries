using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class InvoiceLineRequest
{
    /// <summary>
    ///     Net amount of invoice line in cents in original currency.
    /// </summary>
    /// <value>Net amount of invoice line in cents in original currency.</value>
    [DataMember(Name = "net", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "net")]
    public long? Net { get; set; }

    /// <summary>
    ///     VAT amount of invoice line in cents in original currency.
    /// </summary>
    /// <value>VAT amount of invoice line in cents in original currency.</value>
    [DataMember(Name = "vat", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vat")]
    public long? Vat { get; set; }

    /// <summary>
    ///     Taken from either 1) the line or 2) the product. At least vatType or vatPercent has to be specified. If both are
    ///     specified, Fiken will assert that the given vat type matches the given vat percent for the issue date. One of:
    ///     {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\", \"NONE\"}.
    ///     \"HIGH\" is the most common. Example: High
    /// </summary>
    /// <value>
    ///     Taken from either 1) the line or 2) the product. At least vatType or vatPercent has to be specified. If both are
    ///     specified, Fiken will assert that the given vat type matches the given vat percent for the issue date. One of:
    ///     {\"HIGH\", \"MEDIUM\", \"LOW\", \"EXEMPT\", \"EXEMPT_IMPORT_EXPORT\", \"EXEMPT_REVERSE\", \"OUTSIDE\", \"NONE\"}.
    ///     \"HIGH\" is the most common. Example: High
    /// </value>
    [DataMember(Name = "vatType", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatType")]
    public string VatType { get; set; }

    /// <summary>
    ///     Gross amount of invoice line in cents.
    /// </summary>
    /// <value>Gross amount of invoice line in cents.</value>
    [DataMember(Name = "gross", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "gross")]
    public long? Gross { get; set; }

    /// <summary>
    ///     Percentage value of VAT charged on invoice line. Should be a value between 0 and 100. Can be decimal values such as
    ///     25.5
    /// </summary>
    /// <value>
    ///     Percentage value of VAT charged on invoice line. Should be a value between 0 and 100. Can be decimal values such
    ///     as 25.5
    /// </value>
    [DataMember(Name = "vatInPercent", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatInPercent")]
    public decimal? VatInPercent { get; set; }

    /// <summary>
    ///     Net price per unit in invoice currency (in cents). WARNING - if specified here and different from unitPrice of the
    ///     product, then this amount overwrites the product price on the invoice.
    /// </summary>
    /// <value>
    ///     Net price per unit in invoice currency (in cents). WARNING - if specified here and different from unitPrice of
    ///     the product, then this amount overwrites the product price on the invoice.
    /// </value>
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
    ///     Discount value should be a value between 0 and 100.
    /// </summary>
    /// <value>
    ///     If field is set, all amounts must be given before the discount is applied. The API will calculate the new
    ///     totals. Discount value should be a value between 0 and 100.
    /// </value>
    [DataMember(Name = "discount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "discount")]
    public decimal? Discount { get; set; }

    /// <summary>
    ///     Name of product to be printed on invoice line. Should only be specified when productId is not provided.
    /// </summary>
    /// <value>Name of product to be printed on invoice line. Should only be specified when productId is not provided.</value>
    [DataMember(Name = "productName", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    ///     Product Id of product associated with invoice line.
    /// </summary>
    /// <value>Product Id of product associated with invoice line.</value>
    [DataMember(Name = "productId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "productId")]
    public long? ProductId { get; set; }

    /// <summary>
    ///     Description of the invoiced product or service. WARNING - if specified here and different from description of the
    ///     product, then thisoverwrites the product description on the invoice.
    /// </summary>
    /// <value>
    ///     Description of the invoiced product or service. WARNING - if specified here and different from description of
    ///     the product, then thisoverwrites the product description on the invoice.
    /// </value>
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
    ///     Field is similar to vatType, it defaults to the product's income account. Either the line or the product needs to
    ///     have an income account set. WARNING - if specified here and different from income account of the product, then this
    ///     account overwrites the product account on the invoice.
    /// </summary>
    /// <value>
    ///     Field is similar to vatType, it defaults to the product's income account. Either the line or the product needs
    ///     to have an income account set. WARNING - if specified here and different from income account of the product, then
    ///     this account overwrites the product account on the invoice.
    /// </value>
    [DataMember(Name = "incomeAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "incomeAccount")]
    public string IncomeAccount { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InvoiceLineRequest {\n");
        sb.Append("  Net: ")
          .Append(Net)
          .Append("\n");
        sb.Append("  Vat: ")
          .Append(Vat)
          .Append("\n");
        sb.Append("  VatType: ")
          .Append(VatType)
          .Append("\n");
        sb.Append("  Gross: ")
          .Append(Gross)
          .Append("\n");
        sb.Append("  VatInPercent: ")
          .Append(VatInPercent)
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
        sb.Append("  ProductName: ")
          .Append(ProductName)
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
        sb.Append("  IncomeAccount: ")
          .Append(IncomeAccount)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}