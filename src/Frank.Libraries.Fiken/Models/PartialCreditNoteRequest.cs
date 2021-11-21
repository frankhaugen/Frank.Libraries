using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class PartialCreditNoteRequest
    {
        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "ourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ourReference")]
        public string OurReference { get; set; }

        /// <summary>
        /// Optional - Your reference for invoice, free string format.
        /// </summary>
        /// <value>Optional - Your reference for invoice, free string format.</value>
        [DataMember(Name = "yourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }

        /// <summary>
        /// Reference if sending via EHF.
        /// </summary>
        /// <value>Reference if sending via EHF.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReference")]
        public string OrderReference { get; set; }

        /// <summary>
        /// Optional - Project associated with the credit note.
        /// </summary>
        /// <value>Optional - Project associated with the credit note.</value>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "project")]
        public long? Project { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        /// <value>ISO 4217 currency code</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Date that the credit note is issued, format yyyy-mm-dd
        /// </summary>
        /// <value>Date that the credit note is issued, format yyyy-mm-dd</value>
        [DataMember(Name = "issueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Optional - Id of invoice that the credit note is associated with.
        /// </summary>
        /// <value>Optional - Id of invoice that the credit note is associated with.</value>
        [DataMember(Name = "invoiceId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoiceId")]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// Id of contact that the credit note is associated with.
        /// </summary>
        /// <value>Id of contact that the credit note is associated with.</value>
        [DataMember(Name = "contactId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactId")]
        public long? ContactId { get; set; }

        /// <summary>
        /// Id of contact person that the credit note is associated with (Credit person must belong to the provided contact).
        /// </summary>
        /// <value>Id of contact person that the credit note is associated with (Credit person must belong to the provided contact).</value>
        [DataMember(Name = "contactPersonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPersonId")]
        public long? ContactPersonId { get; set; }

        /// <summary>
        /// Gets or Sets CreditNoteText
        /// </summary>
        [DataMember(Name = "creditNoteText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creditNoteText")]
        public string CreditNoteText { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<CreditNoteLineResult> Lines { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartialCreditNoteRequest {\n");
            sb.Append("  OurReference: ")
              .Append(OurReference)
              .Append("\n");
            sb.Append("  YourReference: ")
              .Append(YourReference)
              .Append("\n");
            sb.Append("  OrderReference: ")
              .Append(OrderReference)
              .Append("\n");
            sb.Append("  Project: ")
              .Append(Project)
              .Append("\n");
            sb.Append("  Currency: ")
              .Append(Currency)
              .Append("\n");
            sb.Append("  IssueDate: ")
              .Append(IssueDate)
              .Append("\n");
            sb.Append("  InvoiceId: ")
              .Append(InvoiceId)
              .Append("\n");
            sb.Append("  ContactId: ")
              .Append(ContactId)
              .Append("\n");
            sb.Append("  ContactPersonId: ")
              .Append(ContactPersonId)
              .Append("\n");
            sb.Append("  CreditNoteText: ")
              .Append(CreditNoteText)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}