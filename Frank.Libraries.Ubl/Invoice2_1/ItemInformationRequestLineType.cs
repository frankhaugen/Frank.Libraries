namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemInformationRequestLineType
    {

        private TimeFrequencyCodeType _timeFrequencyCodeField;

        private SupplyChainActivityTypeCodeType _supplyChainActivityTypeCodeField;

        private ForecastTypeCodeType _forecastTypeCodeField;

        private PerformanceMetricTypeCodeType _performanceMetricTypeCodeField;

        private PeriodType[] _periodField;

        private SalesItemType[] _salesItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeFrequencyCodeType TimeFrequencyCode
        {
            get
            {
                return _timeFrequencyCodeField;
            }
            set
            {
                _timeFrequencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return _supplyChainActivityTypeCodeField;
            }
            set
            {
                _supplyChainActivityTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return _forecastTypeCodeField;
            }
            set
            {
                _forecastTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
        {
            get
            {
                return _performanceMetricTypeCodeField;
            }
            set
            {
                _performanceMetricTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period")]
        public PeriodType[] Period
        {
            get
            {
                return _periodField;
            }
            set
            {
                _periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
        public SalesItemType[] SalesItem
        {
            get
            {
                return _salesItemField;
            }
            set
            {
                _salesItemField = value;
            }
        }
    }
}