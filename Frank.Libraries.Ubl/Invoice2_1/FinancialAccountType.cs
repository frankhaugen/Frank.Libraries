namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("FinancialAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class FinancialAccountType
    {

        private IDType idField;

        private NameType1 nameField;

        private AliasNameType aliasNameField;

        private AccountTypeCodeType accountTypeCodeField;

        private AccountFormatCodeType accountFormatCodeField;

        private CurrencyCodeType currencyCodeField;

        private PaymentNoteType[] paymentNoteField;

        private BranchType financialInstitutionBranchField;

        private CountryType countryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AliasNameType AliasName
        {
            get
            {
                return this.aliasNameField;
            }
            set
            {
                this.aliasNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountTypeCodeType AccountTypeCode
        {
            get
            {
                return this.accountTypeCodeField;
            }
            set
            {
                this.accountTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountFormatCodeType AccountFormatCode
        {
            get
            {
                return this.accountFormatCodeField;
            }
            set
            {
                this.accountFormatCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentNoteType[] PaymentNote
        {
            get
            {
                return this.paymentNoteField;
            }
            set
            {
                this.paymentNoteField = value;
            }
        }

        /// <remarks/>
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return this.financialInstitutionBranchField;
            }
            set
            {
                this.financialInstitutionBranchField = value;
            }
        }

        /// <remarks/>
        public CountryType Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }
}