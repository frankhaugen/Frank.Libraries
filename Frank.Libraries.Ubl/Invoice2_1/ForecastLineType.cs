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

        private IdType _idField;

        private NoteType[] _noteField;

        private FrozenDocumentIndicatorType _frozenDocumentIndicatorField;

        private ForecastTypeCodeType _forecastTypeCodeField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FrozenDocumentIndicatorType FrozenDocumentIndicator
        {
            get
            {
                return _frozenDocumentIndicatorField;
            }
            set
            {
                _frozenDocumentIndicatorField = value;
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