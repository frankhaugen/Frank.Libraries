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

        private IdType _idField;

        private NoteType[] _noteField;

        private ThresholdValueComparisonCodeType _thresholdValueComparisonCodeField;

        private ThresholdQuantityType _thresholdQuantityField;

        private ExceptionStatusCodeType _exceptionStatusCodeField;

        private CollaborationPriorityCodeType _collaborationPriorityCodeField;

        private ExceptionResolutionCodeType _exceptionResolutionCodeField;

        private SupplyChainActivityTypeCodeType _supplyChainActivityTypeCodeField;

        private PerformanceMetricTypeCodeType _performanceMetricTypeCodeField;

        private PeriodType _effectivePeriodField;

        private ItemType[] _supplyItemField;

        private ForecastExceptionCriterionLineType _forecastExceptionCriterionLineField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdValueComparisonCodeType ThresholdValueComparisonCode
        {
            get
            {
                return _thresholdValueComparisonCodeField;
            }
            set
            {
                _thresholdValueComparisonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ThresholdQuantityType ThresholdQuantity
        {
            get
            {
                return _thresholdQuantityField;
            }
            set
            {
                _thresholdQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExceptionStatusCodeType ExceptionStatusCode
        {
            get
            {
                return _exceptionStatusCodeField;
            }
            set
            {
                _exceptionStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CollaborationPriorityCodeType CollaborationPriorityCode
        {
            get
            {
                return _collaborationPriorityCodeField;
            }
            set
            {
                _collaborationPriorityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExceptionResolutionCodeType ExceptionResolutionCode
        {
            get
            {
                return _exceptionResolutionCodeField;
            }
            set
            {
                _exceptionResolutionCodeField = value;
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
        public PeriodType EffectivePeriod
        {
            get
            {
                return _effectivePeriodField;
            }
            set
            {
                _effectivePeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplyItem")]
        public ItemType[] SupplyItem
        {
            get
            {
                return _supplyItemField;
            }
            set
            {
                _supplyItemField = value;
            }
        }

        /// <remarks/>
        public ForecastExceptionCriterionLineType ForecastExceptionCriterionLine
        {
            get
            {
                return _forecastExceptionCriterionLineField;
            }
            set
            {
                _forecastExceptionCriterionLineField = value;
            }
        }
    }
}