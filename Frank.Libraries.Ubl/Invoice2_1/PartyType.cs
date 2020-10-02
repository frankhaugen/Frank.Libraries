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

        private MarkCareIndicatorType markCareIndicatorField;

        private MarkAttentionIndicatorType markAttentionIndicatorField;

        private WebsiteURIType websiteURIField;

        private LogoReferenceIDType logoReferenceIDField;

        private EndpointIDType endpointIDField;

        private IndustryClassificationCodeType industryClassificationCodeField;

        private PartyIdentificationType[] partyIdentificationField;

        private PartyNameType[] partyNameField;

        private LanguageType languageField;

        private AddressType postalAddressField;

        private LocationType1 physicalLocationField;

        private PartyTaxSchemeType[] partyTaxSchemeField;

        private PartyLegalEntityType[] partyLegalEntityField;

        private ContactType contactField;

        private PersonType[] personField;

        private PartyType agentPartyField;

        private ServiceProviderPartyType[] serviceProviderPartyField;

        private PowerOfAttorneyType[] powerOfAttorneyField;

        private FinancialAccountType financialAccountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareIndicatorType MarkCareIndicator
        {
            get
            {
                return markCareIndicatorField;
            }
            set
            {
                markCareIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionIndicatorType MarkAttentionIndicator
        {
            get
            {
                return markAttentionIndicatorField;
            }
            set
            {
                markAttentionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WebsiteURIType WebsiteURI
        {
            get
            {
                return websiteURIField;
            }
            set
            {
                websiteURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LogoReferenceIDType LogoReferenceID
        {
            get
            {
                return logoReferenceIDField;
            }
            set
            {
                logoReferenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndpointIDType EndpointID
        {
            get
            {
                return endpointIDField;
            }
            set
            {
                endpointIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndustryClassificationCodeType IndustryClassificationCode
        {
            get
            {
                return industryClassificationCodeField;
            }
            set
            {
                industryClassificationCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyIdentification")]
        public PartyIdentificationType[] PartyIdentification
        {
            get
            {
                return partyIdentificationField;
            }
            set
            {
                partyIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyName")]
        public PartyNameType[] PartyName
        {
            get
            {
                return partyNameField;
            }
            set
            {
                partyNameField = value;
            }
        }

        /// <remarks/>
        public LanguageType Language
        {
            get
            {
                return languageField;
            }
            set
            {
                languageField = value;
            }
        }

        /// <remarks/>
        public AddressType PostalAddress
        {
            get
            {
                return postalAddressField;
            }
            set
            {
                postalAddressField = value;
            }
        }

        /// <remarks/>
        public LocationType1 PhysicalLocation
        {
            get
            {
                return physicalLocationField;
            }
            set
            {
                physicalLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme")]
        public PartyTaxSchemeType[] PartyTaxScheme
        {
            get
            {
                return partyTaxSchemeField;
            }
            set
            {
                partyTaxSchemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity")]
        public PartyLegalEntityType[] PartyLegalEntity
        {
            get
            {
                return partyLegalEntityField;
            }
            set
            {
                partyLegalEntityField = value;
            }
        }

        /// <remarks/>
        public ContactType Contact
        {
            get
            {
                return contactField;
            }
            set
            {
                contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Person")]
        public PersonType[] Person
        {
            get
            {
                return personField;
            }
            set
            {
                personField = value;
            }
        }

        /// <remarks/>
        public PartyType AgentParty
        {
            get
            {
                return agentPartyField;
            }
            set
            {
                agentPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty")]
        public ServiceProviderPartyType[] ServiceProviderParty
        {
            get
            {
                return serviceProviderPartyField;
            }
            set
            {
                serviceProviderPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney")]
        public PowerOfAttorneyType[] PowerOfAttorney
        {
            get
            {
                return powerOfAttorneyField;
            }
            set
            {
                powerOfAttorneyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return financialAccountField;
            }
            set
            {
                financialAccountField = value;
            }
        }
    }
}