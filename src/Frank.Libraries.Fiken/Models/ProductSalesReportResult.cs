using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class ProductSalesReportResult
{
    /// <summary>
    ///     Gets or Sets Product
    /// </summary>
    [DataMember(Name = "product", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "product")]
    public Product Product { get; set; }

    /// <summary>
    ///     Gets or Sets Sold
    /// </summary>
    [DataMember(Name = "sold", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "sold")]
    public ProductSalesLineInfo Sold { get; set; }

    /// <summary>
    ///     Gets or Sets Credited
    /// </summary>
    [DataMember(Name = "credited", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "credited")]
    public ProductSalesLineInfo Credited { get; set; }

    /// <summary>
    ///     Gets or Sets Sum
    /// </summary>
    [DataMember(Name = "sum", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "sum")]
    public ProductSalesLineInfo Sum { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProductSalesReportResult {\n");
        sb.Append("  Product: ")
          .Append(Product)
          .Append("\n");
        sb.Append("  Sold: ")
          .Append(Sold)
          .Append("\n");
        sb.Append("  Credited: ")
          .Append(Credited)
          .Append("\n");
        sb.Append("  Sum: ")
          .Append(Sum)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}