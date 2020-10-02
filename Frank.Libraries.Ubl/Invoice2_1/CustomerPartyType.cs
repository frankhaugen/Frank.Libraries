namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AccountingCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CustomerPartyType
    {

        private CustomerAssignedAccountIdType _customerAssignedAccountIdField;

        private SupplierAssignedAccountIdType _supplierAssignedAccountIdField;

        private AdditionalAccountIdType[] _additionalAccountIdField;

        private PartyType _partyField;

        private ContactType _deliveryContactField;

        private ContactType _accountingContactField;

        private ContactType _buyerContactField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplierAssignedAccountIdType SupplierAssignedAccountId
        {
            get
            {
                return _supplierAssignedAccountIdField;
            }
            set
            {
                _supplierAssignedAccountIdField = value;
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
        public ContactType DeliveryContact
        {
            get
            {
                return _deliveryContactField;
            }
            set
            {
                _deliveryContactField = value;
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
        public ContactType BuyerContact
        {
            get
            {
                return _buyerContactField;
            }
            set
            {
                _buyerContactField = value;
            }
        }
    }
}