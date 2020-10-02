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

        private RegistrationNameType registrationNameField;

        private CompanyIDType companyIDField;

        private RegistrationDateType registrationDateField;

        private RegistrationExpirationDateType registrationExpirationDateField;

        private CompanyLegalFormCodeType companyLegalFormCodeField;

        private CompanyLegalFormType companyLegalFormField;

        private SoleProprietorshipIndicatorType soleProprietorshipIndicatorField;

        private CompanyLiquidationStatusCodeType companyLiquidationStatusCodeField;

        private CorporateStockAmountType corporateStockAmountField;

        private FullyPaidSharesIndicatorType fullyPaidSharesIndicatorField;

        private AddressType registrationAddressField;

        private CorporateRegistrationSchemeType corporateRegistrationSchemeField;

        private PartyType headOfficePartyField;

        private ShareholderPartyType[] shareholderPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return registrationNameField;
            }
            set
            {
                registrationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyIDType CompanyID
        {
            get
            {
                return companyIDField;
            }
            set
            {
                companyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationDateType RegistrationDate
        {
            get
            {
                return registrationDateField;
            }
            set
            {
                registrationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationExpirationDateType RegistrationExpirationDate
        {
            get
            {
                return registrationExpirationDateField;
            }
            set
            {
                registrationExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormCodeType CompanyLegalFormCode
        {
            get
            {
                return companyLegalFormCodeField;
            }
            set
            {
                companyLegalFormCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLegalFormType CompanyLegalForm
        {
            get
            {
                return companyLegalFormField;
            }
            set
            {
                companyLegalFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
        {
            get
            {
                return soleProprietorshipIndicatorField;
            }
            set
            {
                soleProprietorshipIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyLiquidationStatusCodeType CompanyLiquidationStatusCode
        {
            get
            {
                return companyLiquidationStatusCodeField;
            }
            set
            {
                companyLiquidationStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorporateStockAmountType CorporateStockAmount
        {
            get
            {
                return corporateStockAmountField;
            }
            set
            {
                corporateStockAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
        {
            get
            {
                return fullyPaidSharesIndicatorField;
            }
            set
            {
                fullyPaidSharesIndicatorField = value;
            }
        }

        /// <remarks/>
        public AddressType RegistrationAddress
        {
            get
            {
                return registrationAddressField;
            }
            set
            {
                registrationAddressField = value;
            }
        }

        /// <remarks/>
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return corporateRegistrationSchemeField;
            }
            set
            {
                corporateRegistrationSchemeField = value;
            }
        }

        /// <remarks/>
        public PartyType HeadOfficeParty
        {
            get
            {
                return headOfficePartyField;
            }
            set
            {
                headOfficePartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShareholderParty")]
        public ShareholderPartyType[] ShareholderParty
        {
            get
            {
                return shareholderPartyField;
            }
            set
            {
                shareholderPartyField = value;
            }
        }
    }
}