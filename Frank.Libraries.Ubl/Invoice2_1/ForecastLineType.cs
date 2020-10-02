namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastLineType
    {

        private IDType idField;

        private NoteType[] noteField;

        private FrozenDocumentIndicatorType frozenDocumentIndicatorField;

        private ForecastTypeCodeType forecastTypeCodeField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenDocumentIndicatorType FrozenDocumentIndicator
        {
            get
            {
                return frozenDocumentIndicatorField;
            }
            set
            {
                frozenDocumentIndicatorField = value;
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