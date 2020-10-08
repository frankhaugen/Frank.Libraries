namespace Bilagos.DocumentProcessor.UBL.Document
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
                return this.sourceCurrencyCodeField;
            }
            set
            {
                this.sourceCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceCurrencyBaseRateType SourceCurrencyBaseRate
        {
            get
            {
                return this.sourceCurrencyBaseRateField;
            }
            set
            {
                this.sourceCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyCodeType TargetCurrencyCode
        {
            get
            {
                return this.targetCurrencyCodeField;
            }
            set
            {
                this.targetCurrencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TargetCurrencyBaseRateType TargetCurrencyBaseRate
        {
            get
            {
                return this.targetCurrencyBaseRateField;
            }
            set
            {
                this.targetCurrencyBaseRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExchangeMarketIDType ExchangeMarketID
        {
            get
            {
                return this.exchangeMarketIDField;
            }
            set
            {
                this.exchangeMarketIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CalculationRateType CalculationRate
        {
            get
            {
                return this.calculationRateField;
            }
            set
            {
                this.calculationRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MathematicOperatorCodeType MathematicOperatorCode
        {
            get
            {
                return this.mathematicOperatorCodeField;
            }
            set
            {
                this.mathematicOperatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType1 Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public ContractType ForeignExchangeContract
        {
            get
            {
                return this.foreignExchangeContractField;
            }
            set
            {
                this.foreignExchangeContractField = value;
            }
        }
    }
}