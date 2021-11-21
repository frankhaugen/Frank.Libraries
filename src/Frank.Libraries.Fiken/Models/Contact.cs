using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name = "contactId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactId")]
        public long? ContactId { get; set; }

        /// <summary>
        /// Date that product was last modified in Fiken, format yyyy-mm-dd.
        /// </summary>
        /// <value>Date that product was last modified in Fiken, format yyyy-mm-dd.</value>
        [DataMember(Name = "lastModifiedDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Brreg organiztion number.
        /// </summary>
        /// <value>Brreg organiztion number.</value>
        [DataMember(Name = "organizationNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationNumber")]
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// Gets or Sets CustomerNumber
        /// </summary>
        [DataMember(Name = "customerNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerNumber")]
        public long? CustomerNumber { get; set; }

        /// <summary>
        /// Format 1500:XXXXX
        /// </summary>
        /// <value>Format 1500:XXXXX</value>
        [DataMember(Name = "customerAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customerAccountCode")]
        public string CustomerAccountCode { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// A number that can be used to connect a contact to your own data.
        /// </summary>
        /// <value>A number that can be used to connect a contact to your own data.</value>
        [DataMember(Name = "memberNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "memberNumber")]
        public decimal? MemberNumber { get; set; }

        /// <summary>
        /// Gets or Sets SupplierNumber
        /// </summary>
        [DataMember(Name = "supplierNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplierNumber")]
        public long? SupplierNumber { get; set; }

        /// <summary>
        /// Format 2400:XXXXX
        /// </summary>
        /// <value>Format 2400:XXXXX</value>
        [DataMember(Name = "supplierAccountCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplierAccountCode")]
        public string SupplierAccountCode { get; set; }

        /// <summary>
        /// True if the contact is a customer. It is possible for a contact to be both customer and supplier.
        /// </summary>
        /// <value>True if the contact is a customer. It is possible for a contact to be both customer and supplier.</value>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customer")]
        public bool? Customer { get; set; }

        /// <summary>
        /// True if the contact is a supplier. It is possible for a contact to be both supplier and customer.
        /// </summary>
        /// <value>True if the contact is a supplier. It is possible for a contact to be both supplier and customer.</value>
        [DataMember(Name = "supplier", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "supplier")]
        public bool? Supplier { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "contactPerson", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "contactPerson")]
        public List<ContactPerson> ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "notes")]
        public List<ContactNote> Notes { get; set; }

        /// <summary>
        /// ISO 4217 currency code. Default foreign currency to use when creating invoice to this contact (USD, EUR, SEK etc)
        /// </summary>
        /// <value>ISO 4217 currency code. Default foreign currency to use when creating invoice to this contact (USD, EUR, SEK etc)</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The language to use when sending documents to this contact. NORWEGIAN or ENGLISH. Defaults to NORWEGIAN.
        /// </summary>
        /// <value>The language to use when sending documents to this contact. NORWEGIAN or ENGLISH. Defaults to NORWEGIAN.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Whether the contact has been deactivated (true) or is active (false)
        /// </summary>
        /// <value>Whether the contact has been deactivated (true) or is active (false)</value>
        [DataMember(Name = "inactive", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "inactive")]
        public bool? Inactive { get; set; }

        /// <summary>
        /// Default number of days until due date for invoices.
        /// </summary>
        /// <value>Default number of days until due date for invoices.</value>
        [DataMember(Name = "daysUntilInvoicingDueDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "daysUntilInvoicingDueDate")]
        public int? DaysUntilInvoicingDueDate { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "groups")]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name = "documents", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "documents")]
        public List<Attachment> Documents { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  ContactId: ")
              .Append(ContactId)
              .Append("\n");
            sb.Append("  LastModifiedDate: ")
              .Append(LastModifiedDate)
              .Append("\n");
            sb.Append("  Name: ")
              .Append(Name)
              .Append("\n");
            sb.Append("  Email: ")
              .Append(Email)
              .Append("\n");
            sb.Append("  OrganizationNumber: ")
              .Append(OrganizationNumber)
              .Append("\n");
            sb.Append("  CustomerNumber: ")
              .Append(CustomerNumber)
              .Append("\n");
            sb.Append("  CustomerAccountCode: ")
              .Append(CustomerAccountCode)
              .Append("\n");
            sb.Append("  PhoneNumber: ")
              .Append(PhoneNumber)
              .Append("\n");
            sb.Append("  MemberNumber: ")
              .Append(MemberNumber)
              .Append("\n");
            sb.Append("  SupplierNumber: ")
              .Append(SupplierNumber)
              .Append("\n");
            sb.Append("  SupplierAccountCode: ")
              .Append(SupplierAccountCode)
              .Append("\n");
            sb.Append("  Customer: ")
              .Append(Customer)
              .Append("\n");
            sb.Append("  Supplier: ")
              .Append(Supplier)
              .Append("\n");
            sb.Append("  ContactPerson: ")
              .Append(ContactPerson)
              .Append("\n");
            sb.Append("  Notes: ")
              .Append(Notes)
              .Append("\n");
            sb.Append("  Currency: ")
              .Append(Currency)
              .Append("\n");
            sb.Append("  Language: ")
              .Append(Language)
              .Append("\n");
            sb.Append("  Inactive: ")
              .Append(Inactive)
              .Append("\n");
            sb.Append("  DaysUntilInvoicingDueDate: ")
              .Append(DaysUntilInvoicingDueDate)
              .Append("\n");
            sb.Append("  Address: ")
              .Append(Address)
              .Append("\n");
            sb.Append("  Groups: ")
              .Append(Groups)
              .Append("\n");
            sb.Append("  Documents: ")
              .Append(Documents)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}