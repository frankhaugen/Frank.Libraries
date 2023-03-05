using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class DraftResult
{
    /// <summary>
    ///     Draft ID
    /// </summary>
    /// <value>Draft ID</value>
    [DataMember(Name = "draftId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "draftId")]
    public long? DraftId { get; set; }

    /// <summary>
    ///     UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form
    ///     8-4-4-4-12 for a total of 36 characters.
    /// </summary>
    /// <value>
    ///     UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form
    ///     8-4-4-4-12 for a total of 36 characters.
    /// </value>
    [DataMember(Name = "uuid", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

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
    ///     Gets or Sets Contact
    /// </summary>
    [DataMember(Name = "contact", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "contact")]
    public Contact Contact { get; set; }

    /// <summary>
    ///     Gets or Sets Project
    /// </summary>
    [DataMember(Name = "project", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "project")]
    public ProjectResult Project { get; set; }

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
    ///     Gets or Sets Attachments
    /// </summary>
    [DataMember(Name = "attachments", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "attachments")]
    public List<Attachment> Attachments { get; set; }

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
    public List<DraftLineResult> Lines { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DraftResult {\n");
        sb.Append("  DraftId: ")
          .Append(DraftId)
          .Append("\n");
        sb.Append("  Uuid: ")
          .Append(Uuid)
          .Append("\n");
        sb.Append("  InvoiceIssueDate: ")
          .Append(InvoiceIssueDate)
          .Append("\n");
        sb.Append("  DueDate: ")
          .Append(DueDate)
          .Append("\n");
        sb.Append("  InvoiceNumber: ")
          .Append(InvoiceNumber)
          .Append("\n");
        sb.Append("  Contact: ")
          .Append(Contact)
          .Append("\n");
        sb.Append("  Project: ")
          .Append(Project)
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
        sb.Append("  Attachments: ")
          .Append(Attachments)
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