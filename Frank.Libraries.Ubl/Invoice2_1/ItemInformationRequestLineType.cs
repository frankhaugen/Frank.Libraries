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

        private TimeFrequencyCodeType timeFrequencyCodeField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private ForecastTypeCodeType forecastTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType[] periodField;

        private SalesItemType[] salesItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeFrequencyCodeType TimeFrequencyCode
        {
            get
            {
                return timeFrequencyCodeField;
            }
            set
            {
                timeFrequencyCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
        {
            get
            {
                return supplyChainActivityTypeCodeField;
            }
            set
            {
                supplyChainActivityTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return forecastTypeCodeField;
            }
            set
            {
                forecastTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
        {
            get
            {
                return performanceMetricTypeCodeField;
            }
            set
            {
                performanceMetricTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Period")]
        public PeriodType[] Period
        {
            get
            {
                return periodField;
            }
            set
            {
                periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
        public SalesItemType[] SalesItem
        {
            get
            {
                return salesItemField;
            }
            set
            {
                salesItemField = value;
            }
        }
    }
}