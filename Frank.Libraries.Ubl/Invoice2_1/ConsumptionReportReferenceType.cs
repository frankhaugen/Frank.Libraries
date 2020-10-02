namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionReportReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionReportReferenceType
    {

        private ConsumptionReportIdType _consumptionReportIdField;

        private ConsumptionTypeType _consumptionTypeField;

        private ConsumptionTypeCodeType _consumptionTypeCodeField;

        private TotalConsumedQuantityType _totalConsumedQuantityField;

        private PeriodType _periodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionReportIdType ConsumptionReportId
        {
            get
            {
                return _consumptionReportIdField;
            }
            set
            {
                _consumptionReportIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return _consumptionTypeField;
            }
            set
            {
                _consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return _consumptionTypeCodeField;
            }
            set
            {
                _consumptionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return _totalConsumedQuantityField;
            }
            set
            {
                _totalConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
        {
            get
            {
                return _periodField;
            }
            set
            {
                _periodField = value;
            }
        }
    }
}