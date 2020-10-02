namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PartyType
    {

        private MarkCareIndicatorType _markCareIndicatorField;

        private MarkAttentionIndicatorType _markAttentionIndicatorField;

        private WebsiteUriType _websiteUriField;

        private LogoReferenceIdType _logoReferenceIdField;

        private EndpointIdType _endpointIdField;

        private IndustryClassificationCodeType _industryClassificationCodeField;

        private PartyIdentificationType[] _partyIdentificationField;

        private PartyNameType[] _partyNameField;

        private LanguageType _languageField;

        private AddressType _postalAddressField;

        private LocationType1 _physicalLocationField;

        private PartyTaxSchemeType[] _partyTaxSchemeField;

        private PartyLegalEntityType[] _partyLegalEntityField;

        private ContactType _contactField;

        private PersonType[] _personField;

        private PartyType _agentPartyField;

        private ServiceProviderPartyType[] _serviceProviderPartyField;

        private PowerOfAttorneyType[] _powerOfAttorneyField;

        private FinancialAccountType _financialAccountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareIndicatorType MarkCareIndicator
        {
            get
            {
                return _markCareIndicatorField;
            }
            set
            {
                _markCareIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionIndicatorType MarkAttentionIndicator
        {
            get
            {
                return _markAttentionIndicatorField;
            }
            set
            {
                _markAttentionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WebsiteUriType WebsiteUri
        {
            get
            {
                return _websiteUriField;
            }
            set
            {
                _websiteUriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LogoReferenceIdType LogoReferenceId
        {
            get
            {
                return _logoReferenceIdField;
            }
            set
            {
                _logoReferenceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointIdType EndpointId
        {
            get
            {
                return _endpointIdField;
            }
            set
            {
                _endpointIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndustryClassificationCodeType IndustryClassificationCode
        {
            get
            {
                return _industryClassificationCodeField;
            }
            set
            {
                _industryClassificationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
        public PartyIdentificationType[] PartyIdentification
        {
            get
            {
                return _partyIdentificationField;
            }
            set
            {
                _partyIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyName")]
        public PartyNameType[] PartyName
        {
            get
            {
                return _partyNameField;
            }
            set
            {
                _partyNameField = value;
            }
        }

        /// <remarks/>
        public LanguageType Language
        {
            get
            {
                return _languageField;
            }
            set
            {
                _languageField = value;
            }
        }

        /// <remarks/>
        public AddressType PostalAddress
        {
            get
            {
                return _postalAddressField;
            }
            set
            {
                _postalAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 PhysicalLocation
        {
            get
            {
                return _physicalLocationField;
            }
            set
            {
                _physicalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme")]
        public PartyTaxSchemeType[] PartyTaxScheme
        {
            get
            {
                return _partyTaxSchemeField;
            }
            set
            {
                _partyTaxSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
        public PartyLegalEntityType[] PartyLegalEntity
        {
            get
            {
                return _partyLegalEntityField;
            }
            set
            {
                _partyLegalEntityField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return _contactField;
            }
            set
            {
                _contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Person")]
        public PersonType[] Person
        {
            get
            {
                return _personField;
            }
            set
            {
                _personField = value;
            }
        }

        /// <remarks/>
        public PartyType AgentParty
        {
            get
            {
                return _agentPartyField;
            }
            set
            {
                _agentPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty")]
        public ServiceProviderPartyType[] ServiceProviderParty
        {
            get
            {
                return _serviceProviderPartyField;
            }
            set
            {
                _serviceProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney")]
        public PowerOfAttorneyType[] PowerOfAttorney
        {
            get
            {
                return _powerOfAttorneyField;
            }
            set
            {
                _powerOfAttorneyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return _financialAccountField;
            }
            set
            {
                _financialAccountField = value;
            }
        }
    }
}