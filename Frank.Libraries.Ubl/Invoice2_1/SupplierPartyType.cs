namespace Frank.Libraries.Ubl.Invoice2_1
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
                return customerAssignedAccountIDField;
            }
            set
            {
                customerAssignedAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalAccountIDType[] AdditionalAccountID
        {
            get
            {
                return additionalAccountIDField;
            }
            set
            {
                additionalAccountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DataSendingCapabilityType DataSendingCapability
        {
            get
            {
                return dataSendingCapabilityField;
            }
            set
            {
                dataSendingCapabilityField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return partyField;
            }
            set
            {
                partyField = value;
            }
        }

        /// <remarks/>
        public ContactType DespatchContact
        {
            get
            {
                return despatchContactField;
            }
            set
            {
                despatchContactField = value;
            }
        }

        /// <remarks/>
        public ContactType AccountingContact
        {
            get
            {
                return accountingContactField;
            }
            set
            {
                accountingContactField = value;
            }
        }

        /// <remarks/>
        public ContactType SellerContact
        {
            get
            {
                return sellerContactField;
            }
            set
            {
                sellerContactField = value;
            }
        }
    }
}