namespace Bilagos.DocumentProcessor.UBL.Document
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SupplierPartyType
    {

        private CustomerAssignedAccountIDType customerAssignedAccountIDField;

        private AdditionalAccountIDType[] additionalAccountIDField;

        private DataSendingCapabilityType dataSendingCapabilityField;

        private PartyType partyField;

        private ContactType despatchContactField;

        private ContactType accountingContactField;

        private ContactType sellerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomerAssignedAccountIDType CustomerAssignedAccountID
        {
            get
            {
                return this.customerAssignedAccountIDField;
            }
            set
            {
                this.customerAssignedAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalAccountIDType[] AdditionalAccountID
        {
            get
            {
                return this.additionalAccountIDField;
            }
            set
            {
                this.additionalAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DataSendingCapabilityType DataSendingCapability
        {
            get
            {
                return this.dataSendingCapabilityField;
            }
            set
            {
                this.dataSendingCapabilityField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }

        /// <remarks/>
        public ContactType DespatchContact
        {
            get
            {
                return this.despatchContactField;
            }
            set
            {
                this.despatchContactField = value;
            }
        }

        /// <remarks/>
        public ContactType AccountingContact
        {
            get
            {
                return this.accountingContactField;
            }
            set
            {
                this.accountingContactField = value;
            }
        }

        /// <remarks/>
        public ContactType SellerContact
        {
            get
            {
                return this.sellerContactField;
            }
            set
            {
                this.sellerContactField = value;
            }
        }
    }
}