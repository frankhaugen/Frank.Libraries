namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExchangeRate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ExchangeRateType
    {

        private SourceCurrencyCodeType _sourceCurrencyCodeField;

        private SourceCurrencyBaseRateType _sourceCurrencyBaseRateField;

        private TargetCurrencyCodeType _targetCurrencyCodeField;

        private TargetCurrencyBaseRateType _targetCurrencyBaseRateField;

        private ExchangeMarketIdType _exchangeMarketIdField;

        private CalculationRateType _calculationRateField;

        private MathematicOperatorCodeType _mathematicOperatorCodeField;

        private DateType1 _dateField;

        private ContractType _foreignExchangeContractField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyCodeType SourceCurrencyCode
        {
            get
            {
                return _sourceCurrencyCodeField;
            }
            set
            {
                _sourceCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyBaseRateType SourceCurrencyBaseRate
        {
            get
            {
                return _sourceCurrencyBaseRateField;
            }
            set
            {
                _sourceCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return _targetCurrencyCodeField;
            }
            set
            {
                _targetCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyBaseRateType TargetCurrencyBaseRate
        {
            get
            {
                return _targetCurrencyBaseRateField;
            }
            set
            {
                _targetCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExchangeMarketIdType ExchangeMarketId
        {
            get
            {
                return _exchangeMarketIdField;
            }
            set
            {
                _exchangeMarketIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationRateType CalculationRate
        {
            get
            {
                return _calculationRateField;
            }
            set
            {
                _calculationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MathematicOperatorCodeType MathematicOperatorCode
        {
            get
            {
                return _mathematicOperatorCodeField;
            }
            set
            {
                _mathematicOperatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType1 Date
        {
            get
            {
                return _dateField;
            }
            set
            {
                _dateField = value;
            }
        }

        /// <remarks/>
        public ContractType ForeignExchangeContract
        {
            get
            {
                return _foreignExchangeContractField;
            }
            set
            {
                _foreignExchangeContractField = value;
            }
        }
    }
}