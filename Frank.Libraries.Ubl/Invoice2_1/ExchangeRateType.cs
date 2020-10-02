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

        private SourceCurrencyCodeType sourceCurrencyCodeField;

        private SourceCurrencyBaseRateType sourceCurrencyBaseRateField;

        private TargetCurrencyCodeType targetCurrencyCodeField;

        private TargetCurrencyBaseRateType targetCurrencyBaseRateField;

        private ExchangeMarketIDType exchangeMarketIDField;

        private CalculationRateType calculationRateField;

        private MathematicOperatorCodeType mathematicOperatorCodeField;

        private DateType1 dateField;

        private ContractType foreignExchangeContractField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyCodeType SourceCurrencyCode
        {
            get
            {
                return sourceCurrencyCodeField;
            }
            set
            {
                sourceCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyBaseRateType SourceCurrencyBaseRate
        {
            get
            {
                return sourceCurrencyBaseRateField;
            }
            set
            {
                sourceCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return targetCurrencyCodeField;
            }
            set
            {
                targetCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyBaseRateType TargetCurrencyBaseRate
        {
            get
            {
                return targetCurrencyBaseRateField;
            }
            set
            {
                targetCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExchangeMarketIDType ExchangeMarketID
        {
            get
            {
                return exchangeMarketIDField;
            }
            set
            {
                exchangeMarketIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationRateType CalculationRate
        {
            get
            {
                return calculationRateField;
            }
            set
            {
                calculationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MathematicOperatorCodeType MathematicOperatorCode
        {
            get
            {
                return mathematicOperatorCodeField;
            }
            set
            {
                mathematicOperatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType1 Date
        {
            get
            {
                return dateField;
            }
            set
            {
                dateField = value;
            }
        }

        /// <remarks/>
        public ContractType ForeignExchangeContract
        {
            get
            {
                return foreignExchangeContractField;
            }
            set
            {
                foreignExchangeContractField = value;
            }
        }
    }
}