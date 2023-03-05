using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class ProductSalesLineInfo
{
    /// <summary>
    ///     Gets or Sets Count
    /// </summary>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "count")]
    public long? Count { get; set; }

    /// <summary>
    ///     Gets or Sets Sales
    /// </summary>
    [DataMember(Name = "sales", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "sales")]
    public long? Sales { get; set; }

    /// <summary>
    ///     Net amount excluding VAT in cents (5000 = 50.00)
    /// </summary>
    /// <value>Net amount excluding VAT in cents (5000 = 50.00)</value>
    [DataMember(Name = "netAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "netAmount")]
    public long? NetAmount { get; set; }

    /// <summary>
    ///     VAT amount for sale in cents (500 = 5.00)
    /// </summary>
    /// <value>VAT amount for sale in cents (500 = 5.00)</value>
    [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "vatAmount")]
    public long? VatAmount { get; set; }

    /// <summary>
    ///     Gross amount of sale (net + VAT) in cents (5500 = 55.00)
    /// </summary>
    /// <value>Gross amount of sale (net + VAT) in cents (5500 = 55.00)</value>
    [DataMember(Name = "grossAmount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "grossAmount")]
    public long? GrossAmount { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProductSalesLineInfo {\n");
        sb.Append("  Count: ")
          .Append(Count)
          .Append("\n");
        sb.Append("  Sales: ")
          .Append(Sales)
          .Append("\n");
        sb.Append("  NetAmount: ")
          .Append(NetAmount)
          .Append("\n");
        sb.Append("  VatAmount: ")
          .Append(VatAmount)
          .Append("\n");
        sb.Append("  GrossAmount: ")
          .Append(GrossAmount)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}