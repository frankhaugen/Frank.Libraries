using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class PurchaseRequest
{
    /// <summary>
    ///     Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name = "transactionId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "transactionId")]
    public long? TransactionId { get; set; }

    /// <summary>
    ///     Invoice/sale number or similar.
    /// </summary>
    /// <value>Invoice/sale number or similar.</value>
    [DataMember(Name = "identifier", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    ///     Payment date, format yyyy-mm-dd
    /// </summary>
    /// <value>Payment date, format yyyy-mm-dd</value>
    [DataMember(Name = "date", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    ///     Due date of the invoice, format yyyy-mm-dd
    /// </summary>
    /// <value>Due date of the invoice, format yyyy-mm-dd</value>
    [DataMember(Name = "dueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    ///     Purchased with cash or through a supplier.
    /// </summary>
    /// <value>Purchased with cash or through a supplier.</value>
    [DataMember(Name = "kind", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    ///     Gets or Sets Lines
    /// </summary>
    [DataMember(Name = "lines", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "lines")]
    public List<OrderLine> Lines { get; set; }

    /// <summary>
    ///     Id of supplier if not a cash purchase.
    /// </summary>
    /// <value>Id of supplier if not a cash purchase.</value>
    [DataMember(Name = "supplierId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "supplierId")]
    public long? SupplierId { get; set; }

    /// <summary>
    ///     ISO 4217 currency code
    /// </summary>
    /// <value>ISO 4217 currency code</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    ///     Gets or Sets PaymentAccount
    /// </summary>
    [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentAccount")]
    public string PaymentAccount { get; set; }

    /// <summary>
    ///     Payment date, format yyyy-mm-dd
    /// </summary>
    /// <value>Payment date, format yyyy-mm-dd</value>
    [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paymentDate")]
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    ///     Norwegian KID number. Number from 2 to 25 digits long.
    /// </summary>
    /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
    [DataMember(Name = "kid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "kid")]
    public string Kid { get; set; }

    /// <summary>
    ///     Id of given project.
    /// </summary>
    /// <value>Id of given project.</value>
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
        sb.Append("class PurchaseRequest {\n");
        sb.Append("  TransactionId: ")
          .Append(TransactionId)
          .Append("\n");
        sb.Append("  Identifier: ")
          .Append(Identifier)
          .Append("\n");
        sb.Append("  Date: ")
          .Append(Date)
          .Append("\n");
        sb.Append("  DueDate: ")
          .Append(DueDate)
          .Append("\n");
        sb.Append("  Kind: ")
          .Append(Kind)
          .Append("\n");
        sb.Append("  Lines: ")
          .Append(Lines)
          .Append("\n");
        sb.Append("  SupplierId: ")
          .Append(SupplierId)
          .Append("\n");
        sb.Append("  Currency: ")
          .Append(Currency)
          .Append("\n");
        sb.Append("  PaymentAccount: ")
          .Append(PaymentAccount)
          .Append("\n");
        sb.Append("  PaymentDate: ")
          .Append(PaymentDate)
          .Append("\n");
        sb.Append("  Kid: ")
          .Append(Kid)
          .Append("\n");
        sb.Append("  ProjectId: ")
          .Append(ProjectId)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}