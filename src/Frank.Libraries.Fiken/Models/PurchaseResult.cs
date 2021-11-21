using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class PurchaseResult
    {
        /// <summary>
        /// Id of given purchase.
        /// </summary>
        /// <value>Id of given purchase.</value>
        [DataMember(Name = "purchaseId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "purchaseId")]
        public long? PurchaseId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "transactionId")]
        public long? TransactionId { get; set; }

        /// <summary>
        /// Invoice/sale number or similar.
        /// </summary>
        /// <value>Invoice/sale number or similar.</value>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Payment date, format yyyy-mm-dd
        /// </summary>
        /// <value>Payment date, format yyyy-mm-dd</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Due date of the invoice, format yyyy-mm-dd
        /// </summary>
        /// <value>Due date of the invoice, format yyyy-mm-dd</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Purchased with cash or through a supplier.
        /// </summary>
        /// <value>Purchased with cash or through a supplier.</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name = "paid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paid")]
        public bool? Paid { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "lines", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lines")]
        public List<OrderLine> Lines { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name = "supplier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplier")]
        public Contact Supplier { get; set; }

        /// <summary>
        /// ISO 4217 currency code
        /// </summary>
        /// <value>ISO 4217 currency code</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAccount
        /// </summary>
        [DataMember(Name = "paymentAccount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentAccount")]
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Payment date, format yyyy-mm-dd
        /// </summary>
        /// <value>Payment date, format yyyy-mm-dd</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentDate")]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payments")]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseAttachments
        /// </summary>
        [DataMember(Name = "purchaseAttachments", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "purchaseAttachments")]
        public List<Attachment> PurchaseAttachments { get; set; }

        /// <summary>
        /// Norwegian KID number. Number from 2 to 25 digits long.
        /// </summary>
        /// <value>Norwegian KID number. Number from 2 to 25 digits long.</value>
        [DataMember(Name = "kid", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "project")]
        public List<ProjectResult> Project { get; set; }

        /// <summary>
        /// Whether the purchase has been deleted or not
        /// </summary>
        /// <value>Whether the purchase has been deleted or not</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseResult {\n");
            sb.Append("  PurchaseId: ")
              .Append(PurchaseId)
              .Append("\n");
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
            sb.Append("  Paid: ")
              .Append(Paid)
              .Append("\n");
            sb.Append("  Lines: ")
              .Append(Lines)
              .Append("\n");
            sb.Append("  Supplier: ")
              .Append(Supplier)
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
            sb.Append("  Payments: ")
              .Append(Payments)
              .Append("\n");
            sb.Append("  PurchaseAttachments: ")
              .Append(PurchaseAttachments)
              .Append("\n");
            sb.Append("  Kid: ")
              .Append(Kid)
              .Append("\n");
            sb.Append("  Project: ")
              .Append(Project)
              .Append("\n");
            sb.Append("  Deleted: ")
              .Append(Deleted)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}