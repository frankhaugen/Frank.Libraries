using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models;

/// <summary>
/// </summary>
public class FullCreditNoteRequest
{
    /// <summary>
    ///     Date that the credit note is issued, format yyyy-mm-dd
    /// </summary>
    /// <value>Date that the credit note is issued, format yyyy-mm-dd</value>
    [DataMember(Name = "issueDate", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "issueDate")]
    public DateTime? IssueDate { get; set; }

    /// <summary>
    ///     Id of invoice that the credit note is associated with.
    /// </summary>
    /// <value>Id of invoice that the credit note is associated with.</value>
    [DataMember(Name = "invoiceId", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "invoiceId")]
    public long? InvoiceId { get; set; }

    /// <summary>
    ///     Gets or Sets CreditNoteText
    /// </summary>
    [DataMember(Name = "creditNoteText", EmitDefaultValue = false)]
    [JsonProperty(PropertyName = "creditNoteText")]
    public string CreditNoteText { get; set; }


    /// <summary>
    ///     Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FullCreditNoteRequest {\n");
        sb.Append("  IssueDate: ")
          .Append(IssueDate)
          .Append("\n");
        sb.Append("  InvoiceId: ")
          .Append(InvoiceId)
          .Append("\n");
        sb.Append("  CreditNoteText: ")
          .Append(CreditNoteText)
          .Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}