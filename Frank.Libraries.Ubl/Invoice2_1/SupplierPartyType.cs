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

        private CustomerAssignedAccountIdType _customerAssignedAccountIdField;

        private AdditionalAccountIdType[] _additionalAccountIdField;

        private DataSendingCapabilityType _dataSendingCapabilityField;

        private PartyType _partyField;

        private ContactType _despatchContactField;

        private ContactType _accountingContactField;

        private ContactType _sellerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomerAssignedAccountIdType CustomerAssignedAccountId
        {
            get
            {
                return _customerAssignedAccountIdField;
            }
            set
            {
                _customerAssignedAccountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalAccountIdType[] AdditionalAccountId
        {
            get
            {
                return _additionalAccountIdField;
            }
            set
            {
                _additionalAccountIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DataSendingCapabilityType DataSendingCapability
        {
            get
            {
                return _dataSendingCapabilityField;
            }
            set
            {
                _dataSendingCapabilityField = value;
            }
        }

        /// <remarks/>
        public PartyType Party
        {
            get
            {
                return _partyField;
            }
            set
            {
                _partyField = value;
            }
        }

        /// <remarks/>
        public ContactType DespatchContact
        {
            get
            {
                return _despatchContactField;
            }
            set
            {
                _despatchContactField = value;
            }
        }

        /// <remarks/>
        public ContactType AccountingContact
        {
            get
            {
                return _accountingContactField;
            }
            set
            {
                _accountingContactField = value;
            }
        }

        /// <remarks/>
        public ContactType SellerContact
        {
            get
            {
                return _sellerContactField;
            }
            set
            {
                _sellerContactField = value;
            }
        }
    }
}