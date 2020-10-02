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
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AliasNameType AliasName
        {
            get
            {
                return aliasNameField;
            }
            set
            {
                aliasNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountTypeCodeType AccountTypeCode
        {
            get
            {
                return accountTypeCodeField;
            }
            set
            {
                accountTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountFormatCodeType AccountFormatCode
        {
            get
            {
                return accountFormatCodeField;
            }
            set
            {
                accountFormatCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return currencyCodeField;
            }
            set
            {
                currencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentNoteType[] PaymentNote
        {
            get
            {
                return paymentNoteField;
            }
            set
            {
                paymentNoteField = value;
            }
        }

        /// <remarks/>
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return financialInstitutionBranchField;
            }
            set
            {
                financialInstitutionBranchField = value;
            }
        }

        /// <remarks/>
        public CountryType Country
        {
            get
            {
                return countryField;
            }
            set
            {
                countryField = value;
            }
        }
    }
}