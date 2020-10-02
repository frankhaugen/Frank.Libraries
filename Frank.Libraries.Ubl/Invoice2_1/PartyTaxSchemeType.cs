namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PartyTaxSchemeType
    {

        private RegistrationNameType _registrationNameField;

        private CompanyIdType _companyIdField;

        private TaxLevelCodeType _taxLevelCodeField;

        private ExemptionReasonCodeType _exemptionReasonCodeField;

        private ExemptionReasonType[] _exemptionReasonField;

        private AddressType _registrationAddressField;

        private TaxSchemeType _taxSchemeField;

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
        public TaxLevelCodeType TaxLevelCode
        {
            get
            {
                return _taxLevelCodeField;
            }
            set
            {
                _taxLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExemptionReasonCodeType ExemptionReasonCode
        {
            get
            {
                return _exemptionReasonCodeField;
            }
            set
            {
                _exemptionReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExemptionReasonType[] ExemptionReason
        {
            get
            {
                return _exemptionReasonField;
            }
            set
            {
                _exemptionReasonField = value;
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
        public TaxSchemeType TaxScheme
        {
            get
            {
                return _taxSchemeField;
            }
            set
            {
                _taxSchemeField = value;
            }
        }
    }
}