namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PreviousPriceList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PriceListType
    {

        private IdType _idField;

        private StatusCodeType _statusCodeField;

        private PeriodType[] _validityPeriodField;

        private PriceListType _previousPriceListField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StatusCodeType StatusCode
        {
            get
            {
                return _statusCodeField;
            }
            set
            {
                _statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PriceListType PreviousPriceList
        {
            get
            {
                return _previousPriceListField;
            }
            set
            {
                _previousPriceListField = value;
            }
        }
    }
}