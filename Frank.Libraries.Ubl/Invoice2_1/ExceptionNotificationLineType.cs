namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExceptionNotificationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ExceptionNotificationLineType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private DescriptionType[] _descriptionField;

        private ExceptionStatusCodeType _exceptionStatusCodeField;

        private CollaborationPriorityCodeType _collaborationPriorityCodeField;

        private ResolutionCodeType _resolutionCodeField;

        private ComparedValueMeasureType _comparedValueMeasureField;

        private SourceValueMeasureType _sourceValueMeasureField;

        private VarianceQuantityType _varianceQuantityField;

        private SupplyChainActivityTypeCodeType _supplyChainActivityTypeCodeField;

        private PerformanceMetricTypeCodeType _performanceMetricTypeCodeField;

        private PeriodType _exceptionObservationPeriodField;

        private DocumentReferenceType[] _documentReferenceField;

        private ForecastExceptionType _forecastExceptionField;

        private ItemType _supplyItemField;

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
        public ResolutionCodeType ResolutionCode
        {
            get
            {
                return _resolutionCodeField;
            }
            set
            {
                _resolutionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparedValueMeasureType ComparedValueMeasure
        {
            get
            {
                return _comparedValueMeasureField;
            }
            set
            {
                _comparedValueMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceValueMeasureType SourceValueMeasure
        {
            get
            {
                return _sourceValueMeasureField;
            }
            set
            {
                _sourceValueMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VarianceQuantityType VarianceQuantity
        {
            get
            {
                return _varianceQuantityField;
            }
            set
            {
                _varianceQuantityField = value;
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
        public PeriodType ExceptionObservationPeriod
        {
            get
            {
                return _exceptionObservationPeriodField;
            }
            set
            {
                _exceptionObservationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ForecastExceptionType ForecastException
        {
            get
            {
                return _forecastExceptionField;
            }
            set
            {
                _forecastExceptionField = value;
            }
        }

        /// <remarks/>
        public ItemType SupplyItem
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
    }
}