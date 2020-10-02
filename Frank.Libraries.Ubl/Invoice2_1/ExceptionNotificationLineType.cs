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

        private IDType idField;

        private NoteType[] noteField;

        private DescriptionType[] descriptionField;

        private ExceptionStatusCodeType exceptionStatusCodeField;

        private CollaborationPriorityCodeType collaborationPriorityCodeField;

        private ResolutionCodeType resolutionCodeField;

        private ComparedValueMeasureType comparedValueMeasureField;

        private SourceValueMeasureType sourceValueMeasureField;

        private VarianceQuantityType varianceQuantityField;

        private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

        private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

        private PeriodType exceptionObservationPeriodField;

        private DocumentReferenceType[] documentReferenceField;

        private ForecastExceptionType forecastExceptionField;

        private ItemType supplyItemField;

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
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
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
        public ResolutionCodeType ResolutionCode
        {
            get
            {
                return resolutionCodeField;
            }
            set
            {
                resolutionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparedValueMeasureType ComparedValueMeasure
        {
            get
            {
                return comparedValueMeasureField;
            }
            set
            {
                comparedValueMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceValueMeasureType SourceValueMeasure
        {
            get
            {
                return sourceValueMeasureField;
            }
            set
            {
                sourceValueMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VarianceQuantityType VarianceQuantity
        {
            get
            {
                return varianceQuantityField;
            }
            set
            {
                varianceQuantityField = value;
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
        public PeriodType ExceptionObservationPeriod
        {
            get
            {
                return exceptionObservationPeriodField;
            }
            set
            {
                exceptionObservationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        public ForecastExceptionType ForecastException
        {
            get
            {
                return forecastExceptionField;
            }
            set
            {
                forecastExceptionField = value;
            }
        }

        /// <remarks/>
        public ItemType SupplyItem
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
    }
}