namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastRevisionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastRevisionLineType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private DescriptionType[] _descriptionField;

        private RevisedForecastLineIdType _revisedForecastLineIdField;

        private SourceForecastIssueDateType _sourceForecastIssueDateField;

        private SourceForecastIssueTimeType _sourceForecastIssueTimeField;

        private AdjustmentReasonCodeType _adjustmentReasonCodeField;

        private PeriodType _forecastPeriodField;

        private SalesItemType _salesItemField;

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
        public RevisedForecastLineIdType RevisedForecastLineId
        {
            get
            {
                return _revisedForecastLineIdField;
            }
            set
            {
                _revisedForecastLineIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceForecastIssueDateType SourceForecastIssueDate
        {
            get
            {
                return _sourceForecastIssueDateField;
            }
            set
            {
                _sourceForecastIssueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceForecastIssueTimeType SourceForecastIssueTime
        {
            get
            {
                return _sourceForecastIssueTimeField;
            }
            set
            {
                _sourceForecastIssueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdjustmentReasonCodeType AdjustmentReasonCode
        {
            get
            {
                return _adjustmentReasonCodeField;
            }
            set
            {
                _adjustmentReasonCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType ForecastPeriod
        {
            get
            {
                return _forecastPeriodField;
            }
            set
            {
                _forecastPeriodField = value;
            }
        }

        /// <remarks/>
        public SalesItemType SalesItem
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