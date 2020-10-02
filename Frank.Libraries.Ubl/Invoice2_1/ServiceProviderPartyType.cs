namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ServiceProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ServiceProviderPartyType
    {

        private IdType _idField;

        private ServiceTypeCodeType _serviceTypeCodeField;

        private ServiceTypeType[] _serviceTypeField;

        private PartyType _partyField;

        private ContactType _sellerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceTypeCodeType ServiceTypeCode
        {
            get
            {
                return _serviceTypeCodeField;
            }
            set
            {
                _serviceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceTypeType[] ServiceType
        {
            get
            {
                return _serviceTypeField;
            }
            set
            {
                _serviceTypeField = value;
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