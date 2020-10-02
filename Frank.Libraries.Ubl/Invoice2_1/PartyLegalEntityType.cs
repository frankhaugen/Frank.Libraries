namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PartyLegalEntityType
    {

        private RegistrationNameType _registrationNameField;

        private CompanyIdType _companyIdField;

        private RegistrationDateType _registrationDateField;

        private RegistrationExpirationDateType _registrationExpirationDateField;

        private CompanyLegalFormCodeType _companyLegalFormCodeField;

        private CompanyLegalFormType _companyLegalFormField;

        private SoleProprietorshipIndicatorType _soleProprietorshipIndicatorField;

        private CompanyLiquidationStatusCodeType _companyLiquidationStatusCodeField;

        private CorporateStockAmountType _corporateStockAmountField;

        private FullyPaidSharesIndicatorType _fullyPaidSharesIndicatorField;

        private AddressType _registrationAddressField;

        private CorporateRegistrationSchemeType _corporateRegistrationSchemeField;

        private PartyType _headOfficePartyField;

        private ShareholderPartyType[] _shareholderPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return _registrationNameField;
            }
            set
            {
                _registrationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyIdType CompanyId
        {
            get
            {
                return _companyIdField;
            }
            set
            {
                _companyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationDateType RegistrationDate
        {
            get
            {
                return _registrationDateField;
            }
            set
            {
                _registrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationExpirationDateType RegistrationExpirationDate
        {
            get
            {
                return _registrationExpirationDateField;
            }
            set
            {
                _registrationExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCodeType CompanyLegalFormCode
        {
            get
            {
                return _companyLegalFormCodeField;
            }
            set
            {
                _companyLegalFormCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormType CompanyLegalForm
        {
            get
            {
                return _companyLegalFormField;
            }
            set
            {
                _companyLegalFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
        {
            get
            {
                return _soleProprietorshipIndicatorField;
            }
            set
            {
                _soleProprietorshipIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLiquidationStatusCodeType CompanyLiquidationStatusCode
        {
            get
            {
                return _companyLiquidationStatusCodeField;
            }
            set
            {
                _companyLiquidationStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateStockAmountType CorporateStockAmount
        {
            get
            {
                return _corporateStockAmountField;
            }
            set
            {
                _corporateStockAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
        {
            get
            {
                return _fullyPaidSharesIndicatorField;
            }
            set
            {
                _fullyPaidSharesIndicatorField = value;
            }
        }

        /// <remarks/>
        public AddressType RegistrationAddress
        {
            get
            {
                return _registrationAddressField;
            }
            set
            {
                _registrationAddressField = value;
            }
        }

        /// <remarks/>
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return _corporateRegistrationSchemeField;
            }
            set
            {
                _corporateRegistrationSchemeField = value;
            }
        }

        /// <remarks/>
        public PartyType HeadOfficeParty
        {
            get
            {
                return _headOfficePartyField;
            }
            set
            {
                _headOfficePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShareholderParty")]
        public ShareholderPartyType[] ShareholderParty
        {
            get
            {
                return _shareholderPartyField;
            }
            set
            {
                _shareholderPartyField = value;
            }
        }
    }
}