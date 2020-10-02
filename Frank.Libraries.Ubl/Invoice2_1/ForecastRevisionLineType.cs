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

        private IDType idField;

        private NoteType[] noteField;

        private DescriptionType[] descriptionField;

        private RevisedForecastLineIDType revisedForecastLineIDField;

        private SourceForecastIssueDateType sourceForecastIssueDateField;

        private SourceForecastIssueTimeType sourceForecastIssueTimeField;

        private AdjustmentReasonCodeType adjustmentReasonCodeField;

        private PeriodType forecastPeriodField;

        private SalesItemType salesItemField;

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
        public RevisedForecastLineIDType RevisedForecastLineID
        {
            get
            {
                return revisedForecastLineIDField;
            }
            set
            {
                revisedForecastLineIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceForecastIssueDateType SourceForecastIssueDate
        {
            get
            {
                return sourceForecastIssueDateField;
            }
            set
            {
                sourceForecastIssueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SourceForecastIssueTimeType SourceForecastIssueTime
        {
            get
            {
                return sourceForecastIssueTimeField;
            }
            set
            {
                sourceForecastIssueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdjustmentReasonCodeType AdjustmentReasonCode
        {
            get
            {
                return adjustmentReasonCodeField;
            }
            set
            {
                adjustmentReasonCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType ForecastPeriod
        {
            get
            {
                return forecastPeriodField;
            }
            set
            {
                forecastPeriodField = value;
            }
        }

        /// <remarks/>
        public SalesItemType SalesItem
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