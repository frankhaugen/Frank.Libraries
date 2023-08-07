using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class DraftRequest
{
    /// <summary>
    ///     Issue date of the draft, format yyyy-mm-dd
    /// </summary>
    /// <value>Issue date of the draft, format yyyy-mm-dd</value>
    [DataMember(Name = "invoiceIssueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "invoiceIssueDate")]
    public DateTime? InvoiceIssueDate { get; set; }

    /// <summary>
    ///     Due date of draft, format yyyy-mm-dd
    /// </summary>
    /// <value>Due date of draft, format yyyy-mm-dd</value>
    [DataMember(Name = "dueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "dueDate")]
    public DateTime? DueDate { get; set; }

    /// <summary>
    ///     If invoice associated with draft, this is the invoice number (not to be confused with the invoiceId of an invoice
    ///     issued from Fiken)
    /// </summary>
    /// <value>
    ///     If invoice associated with draft, this is the invoice number (not to be confused with the invoiceId of an
    ///     invoice issued from Fiken)
    /// </value>
    [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    ///     Contact Id
    /// </summary>
    /// <value>Contact Id</value>
    [DataMember(Name = "contactId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contactId")]
    public long? ContactId { get; set; }

    /// <summary>
    ///     Project ID if only 1 project associated with entire draft. It is also possible to specify the project on individual
    ///     draft lines
    /// </summary>
    /// <value>
    ///     Project ID if only 1 project associated with entire draft. It is also possible to specify the project on
    ///     individual draft lines
    /// </value>
    [DataMember(Name = "projectId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "projectId")]
    public long? ProjectId { get; set; }

    /// <summary>
    ///     If a cash sale/purchase (true) or otherwise (false)
    /// </summary>
    /// <value>If a cash sale/purchase (true) or otherwise (false)</value>
    [DataMember(Name = "cash", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "cash")]
    public bool? Cash { get; set; }

    /// <summary>
    ///     ISO 4217 currency code
    /// </summary>
    /// <value>ISO 4217 currency code</value>
    [DataMember(Name = "currency", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    ///     Norwegian KID number. Number from 2 to 25 digits long.
    /// </summary>
    /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
    [DataMember(Name = "kid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "kid")]
    public string Kid { get; set; }

    /// <summary>
    ///     Whether the sale/purchase has been paid (true) or not (false)
    /// </summary>
    /// <value>Whether the sale/purchase has been paid (true) or not (false)</value>
    [DataMember(Name = "paid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "paid")]
    public bool? Paid { get; set; }

    /// <summary>
    ///     Gets or Sets Payments
    /// </summary>
    [DataMember(Name = "payments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "payments")]
    public List<Payment> Payments { get; set; }

    /// <summary>
    ///     Gets or Sets Lines
    /// </summary>
    [DataMember(Name = "lines", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "lines")]
    public List<DraftLineRequest> Lines { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DraftRequest {\n");
        sb.Append("  InvoiceIssueDate: ")
          .Append(InvoiceIssueDate)
          .Append("\n");
        sb.Append("  DueDate: ")
          .Append(DueDate)
          .Append("\n");
        sb.Append("  InvoiceNumber: ")
          .Append(InvoiceNumber)
          .Append("\n");
        sb.Append("  ContactId: ")
          .Append(ContactId)
          .Append("\n");
        sb.Append("  ProjectId: ")
          .Append(ProjectId)
          .Append("\n");
        sb.Append("  Cash: ")
          .Append(Cash)
          .Append("\n");
        sb.Append("  Currency: ")
          .Append(Currency)
          .Append("\n");
        sb.Append("  Kid: ")
          .Append(Kid)
          .Append("\n");
        sb.Append("  Paid: ")
          .Append(Paid)
          .Append("\n");
        sb.Append("  Payments: ")
          .Append(Payments)
          .Append("\n");
        sb.Append("  Lines: ")
          .Append(Lines)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}