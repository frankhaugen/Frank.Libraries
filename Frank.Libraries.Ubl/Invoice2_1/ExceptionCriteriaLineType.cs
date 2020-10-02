namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExceptionCriteriaLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ExceptionCriteriaLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private ThresholdValueComparisonCodeType thresholdValueComparisonCodeField;

        private ThresholdQuantityType thresholdQuantityField;

        private ExceptionStatusCodeType exceptionStatusCodeField;

        private CollaborationPriorityCodeType collaborationPriorityCodeField;

        private ExceptionResolutionCodeType exceptionResolutionCodeField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType effectivePeriodField;

        private ItemType[] supplyItemField;

        private ForecastExceptionCriterionLineType forecastExceptionCriterionLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdValueComparisonCodeType ThresholdValueComparisonCode
        {
            get
            {
                return thresholdValueComparisonCodeField;
            }
            set
            {
                thresholdValueComparisonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdQuantityType ThresholdQuantity
        {
            get
            {
                return thresholdQuantityField;
            }
            set
            {
                thresholdQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExceptionStatusCodeType ExceptionStatusCode
        {
            get
            {
                return exceptionStatusCodeField;
            }
            set
            {
                exceptionStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CollaborationPriorityCodeType CollaborationPriorityCode
        {
            get
            {
                return collaborationPriorityCodeField;
            }
            set
            {
                collaborationPriorityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExceptionResolutionCodeType ExceptionResolutionCode
        {
            get
            {
                return exceptionResolutionCodeField;
            }
            set
            {
                exceptionResolutionCodeField = value;
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
        public PeriodType EffectivePeriod
        {
            get
            {
                return effectivePeriodField;
            }
            set
            {
                effectivePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplyItem")]
        public ItemType[] SupplyItem
        {
            get
            {
                return supplyItemField;
            }
            set
            {
                supplyItemField = value;
            }
        }

        /// <remarks/>
        public ForecastExceptionCriterionLineType ForecastExceptionCriterionLine
        {
            get
            {
                return forecastExceptionCriterionLineField;
            }
            set
            {
                forecastExceptionCriterionLineField = value;
            }
        }
    }
}