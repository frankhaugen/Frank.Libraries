using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class InvoiceishDraftRequest
    {
        /// <summary>
        /// Type of draft.
        /// </summary>
        /// <value>Type of draft.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters.
        /// </summary>
        /// <value>UUID are represented as 32 hexadecimal (base-16) digits, displayed in 5 groups separated by hyphens, in the form 8-4-4-4-12 for a total of 36 characters.</value>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Issue date of the invoice draft, format yyyy-mm-dd
        /// </summary>
        /// <value>Issue date of the invoice draft, format yyyy-mm-dd</value>
        [DataMember(Name = "issueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// Days until due date of the invoice draft.
        /// </summary>
        /// <value>Days until due date of the invoice draft.</value>
        [DataMember(Name = "daysUntilDueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "daysUntilDueDate")]
        public int? DaysUntilDueDate { get; set; }

        /// <summary>
        /// Comment/description printed above the invoice lines
        /// </summary>
        /// <value>Comment/description printed above the invoice lines</value>
        [DataMember(Name = "invoiceText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "invoiceText")]
        public string InvoiceText { get; set; }

        /// <summary>
        /// Gets or Sets YourReference
        /// </summary>
        [DataMember(Name = "yourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "yourReference")]
        public string YourReference { get; set; }

        /// <summary>
        /// Gets or Sets OurReference
        /// </summary>
        [DataMember(Name = "ourReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ourReference")]
        public string OurReference { get; set; }

        /// <summary>
        /// Reference if sending invoice via EHF.
        /// </summary>
        /// <value>Reference if sending invoice via EHF.</value>
        [DataMember(Name = "orderReference", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "orderReference")]
        public string OrderReference { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<InvoiceishDraftLine> Lines { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        /// <value>ISO 4217 currency code</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountNumber
        /// </summary>
        [DataMember(Name = "bankAccountNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "iban")]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [DataMember(Name = "bic", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "bic")]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentAccount")]
        public string PaymentAccount { get; set; }

        /// <summary>
        /// customerId = contactId where customer = true
        /// </summary>
        /// <value>customerId = contactId where customer = true</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerId")]
        public long? CustomerId { get; set; }

        /// <summary>
        /// Id of the contact person. Must be associated with the provided customer.
        /// </summary>
        /// <value>Id of the contact person. Must be associated with the provided customer.</value>
        [DataMember(Name = "contactPersonId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPersonId")]
        public long? ContactPersonId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "projectId")]
        public long? ProjectId { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceishDraftRequest {\n");
            sb.Append("  Type: ")
              .Append(Type)
              .Append("\n");
            sb.Append("  Uuid: ")
              .Append(Uuid)
              .Append("\n");
            sb.Append("  IssueDate: ")
              .Append(IssueDate)
              .Append("\n");
            sb.Append("  DaysUntilDueDate: ")
              .Append(DaysUntilDueDate)
              .Append("\n");
            sb.Append("  InvoiceText: ")
              .Append(InvoiceText)
              .Append("\n");
            sb.Append("  YourReference: ")
              .Append(YourReference)
              .Append("\n");
            sb.Append("  OurReference: ")
              .Append(OurReference)
              .Append("\n");
            sb.Append("  OrderReference: ")
              .Append(OrderReference)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("  Currency: ")
              .Append(Currency)
              .Append("\n");
            sb.Append("  BankAccountNumber: ")
              .Append(BankAccountNumber)
              .Append("\n");
            sb.Append("  Iban: ")
              .Append(Iban)
              .Append("\n");
            sb.Append("  Bic: ")
              .Append(Bic)
              .Append("\n");
            sb.Append("  PaymentAccount: ")
              .Append(PaymentAccount)
              .Append("\n");
            sb.Append("  CustomerId: ")
              .Append(CustomerId)
              .Append("\n");
            sb.Append("  ContactPersonId: ")
              .Append(ContactPersonId)
              .Append("\n");
            sb.Append("  ProjectId: ")
              .Append(ProjectId)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}