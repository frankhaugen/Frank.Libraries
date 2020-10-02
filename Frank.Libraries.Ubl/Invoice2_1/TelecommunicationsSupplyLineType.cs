namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupplyLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TelecommunicationsSupplyLineType
    {

        private IdType _idField;

        private PhoneNumberType _phoneNumberField;

        private DescriptionType[] _descriptionField;

        private LineExtensionAmountType _lineExtensionAmountField;

        private ExchangeRateType[] _exchangeRateField;

        private AllowanceChargeType[] _allowanceChargeField;

        private TaxTotalType[] _taxTotalField;

        private TelecommunicationsServiceType[] _telecommunicationsServiceField;

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
        public PhoneNumberType PhoneNumber
        {
            get
            {
                return _phoneNumberField;
            }
            set
            {
                _phoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return _lineExtensionAmountField;
            }
            set
            {
                _lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExchangeRate")]
        public ExchangeRateType[] ExchangeRate
        {
            get
            {
                return _exchangeRateField;
            }
            set
            {
                _exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return _allowanceChargeField;
            }
            set
            {
                _allowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return _taxTotalField;
            }
            set
            {
                _taxTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsService")]
        public TelecommunicationsServiceType[] TelecommunicationsService
        {
            get
            {
                return _telecommunicationsServiceField;
            }
            set
            {
                _telecommunicationsServiceField = value;
            }
        }
    }
}