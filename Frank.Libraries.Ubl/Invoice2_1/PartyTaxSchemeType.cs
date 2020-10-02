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

        private RegistrationNameType registrationNameField;

        private CompanyIDType companyIDField;

        private TaxLevelCodeType taxLevelCodeField;

        private ExemptionReasonCodeType exemptionReasonCodeField;

        private ExemptionReasonType[] exemptionReasonField;

        private AddressType registrationAddressField;

        private TaxSchemeType taxSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return this.registrationNameField;
            }
            set
            {
                this.registrationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CompanyIDType CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxLevelCodeType TaxLevelCode
        {
            get
            {
                return this.taxLevelCodeField;
            }
            set
            {
                this.taxLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExemptionReasonCodeType ExemptionReasonCode
        {
            get
            {
                return this.exemptionReasonCodeField;
            }
            set
            {
                this.exemptionReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExemptionReasonType[] ExemptionReason
        {
            get
            {
                return this.exemptionReasonField;
            }
            set
            {
                this.exemptionReasonField = value;
            }
        }

        /// <remarks/>
        public AddressType RegistrationAddress
        {
            get
            {
                return this.registrationAddressField;
            }
            set
            {
                this.registrationAddressField = value;
            }
        }

        /// <remarks/>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
            }
        }
    }
}