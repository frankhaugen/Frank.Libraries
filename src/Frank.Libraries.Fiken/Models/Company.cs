using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Frank.Libraries.Fiken.Models
{
    /// <summary>
    ///
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Name of company.
        /// </summary>
        /// <value>Name of company.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Formatted name of company.
        /// </summary>
        /// <value>Formatted name of company.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Brreg organization number.
        /// </summary>
        /// <value>Brreg organization number.</value>
        [DataMember(Name = "organizationNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "organizationNumber")]
        public string OrganizationNumber { get; set; }

        /// <summary>
        /// Gets or Sets VatType
        /// </summary>
        [DataMember(Name = "vatType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "vatType")]
        public string VatType { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creationDate")]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets HasApiAccess
        /// </summary>
        [DataMember(Name = "hasApiAccess", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasApiAccess")]
        public bool? HasApiAccess { get; set; }

        /// <summary>
        /// Whether the company is a demo (true) or not
        /// </summary>
        /// <value>Whether the company is a demo (true) or not</value>
        [DataMember(Name = "testCompany", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "testCompany")]
        public bool? TestCompany { get; set; }

        /// <summary>
        /// Gets or Sets AccountingStartDate
        /// </summary>
        [DataMember(Name = "accountingStartDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "accountingStartDate")]
        public DateTime? AccountingStartDate { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Company {\n");
            sb.Append("  Name: ")
              .Append(Name)
              .Append("\n");
            sb.Append("  Slug: ")
              .Append(Slug)
              .Append("\n");
            sb.Append("  OrganizationNumber: ")
              .Append(OrganizationNumber)
              .Append("\n");
            sb.Append("  VatType: ")
              .Append(VatType)
              .Append("\n");
            sb.Append("  Address: ")
              .Append(Address)
              .Append("\n");
            sb.Append("  PhoneNumber: ")
              .Append(PhoneNumber)
              .Append("\n");
            sb.Append("  Email: ")
              .Append(Email)
              .Append("\n");
            sb.Append("  CreationDate: ")
              .Append(CreationDate)
              .Append("\n");
            sb.Append("  HasApiAccess: ")
              .Append(HasApiAccess)
              .Append("\n");
            sb.Append("  TestCompany: ")
              .Append(TestCompany)
              .Append("\n");
            sb.Append("  AccountingStartDate: ")
              .Append(AccountingStartDate)
              .Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}