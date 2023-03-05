using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class ProductSalesReportRequest
{
    /// <summary>
    ///     Start date range for the report, inclusive, format yyyy-mm-dd
    /// </summary>
    /// <value>Start date range for the report, inclusive, format yyyy-mm-dd</value>
    [DataMember(Name = "from", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "from")]
    public DateTime? From { get; set; }

    /// <summary>
    ///     End date range for the report, inclusive, format yyyy-mm-dd
    /// </summary>
    /// <value>End date range for the report, inclusive, format yyyy-mm-dd</value>
    [DataMember(Name = "to", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "to")]
    public DateTime? To { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProductSalesReportRequest {\n");
        sb.Append("  From: ")
          .Append(From)
          .Append("\n");
        sb.Append("  To: ")
          .Append(To)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}