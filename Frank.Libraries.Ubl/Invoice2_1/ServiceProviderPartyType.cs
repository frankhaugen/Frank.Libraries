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

        private IDType idField;

        private ServiceTypeCodeType serviceTypeCodeField;

        private ServiceTypeType[] serviceTypeField;

        private PartyType partyField;

        private ContactType sellerContactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceTypeCodeType ServiceTypeCode
        {
            get
            {
                return serviceTypeCodeField;
            }
            set
            {
                serviceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceTypeType[] ServiceType
        {
            get
            {
                return serviceTypeField;
            }
            set
            {
                serviceTypeField = value;
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