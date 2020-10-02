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

        private CustomerAssignedAccountIDType customerAssignedAccountIDField;

        private SupplierAssignedAccountIDType supplierAssignedAccountIDField;

        private AdditionalAccountIDType[] additionalAccountIDField;

        private PartyType partyField;

        private ContactType deliveryContactField;

        private ContactType accountingContactField;

        private ContactType buyerContactField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplierAssignedAccountIDType SupplierAssignedAccountID
        {
            get
            {
                return supplierAssignedAccountIDField;
            }
            set
            {
                supplierAssignedAccountIDField = value;
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
        public ContactType DeliveryContact
        {
            get
            {
                return deliveryContactField;
            }
            set
            {
                deliveryContactField = value;
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
        public ContactType BuyerContact
        {
            get
            {
                return buyerContactField;
            }
            set
            {
                buyerContactField = value;
            }
        }
    }
}