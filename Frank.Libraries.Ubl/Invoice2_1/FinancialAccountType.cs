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

        private IdType _idField;

        private NameType1 _nameField;

        private AliasNameType _aliasNameField;

        private AccountTypeCodeType _accountTypeCodeField;

        private AccountFormatCodeType _accountFormatCodeField;

        private CurrencyCodeType _currencyCodeField;

        private PaymentNoteType[] _paymentNoteField;

        private BranchType _financialInstitutionBranchField;

        private CountryType _countryField;

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
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AliasNameType AliasName
        {
            get
            {
                return _aliasNameField;
            }
            set
            {
                _aliasNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountTypeCodeType AccountTypeCode
        {
            get
            {
                return _accountTypeCodeField;
            }
            set
            {
                _accountTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountFormatCodeType AccountFormatCode
        {
            get
            {
                return _accountFormatCodeField;
            }
            set
            {
                _accountFormatCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return _currencyCodeField;
            }
            set
            {
                _currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentNoteType[] PaymentNote
        {
            get
            {
                return _paymentNoteField;
            }
            set
            {
                _paymentNoteField = value;
            }
        }

        /// <remarks/>
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return _financialInstitutionBranchField;
            }
            set
            {
                _financialInstitutionBranchField = value;
            }
        }

        /// <remarks/>
        public CountryType Country
        {
            get
            {
                return _countryField;
            }
            set
            {
                _countryField = value;
            }
        }
    }
}