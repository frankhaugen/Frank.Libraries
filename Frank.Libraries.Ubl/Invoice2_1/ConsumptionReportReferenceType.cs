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

        private ConsumptionReportIDType consumptionReportIDField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private TotalConsumedQuantityType totalConsumedQuantityField;

        private PeriodType periodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionReportIDType ConsumptionReportID
        {
            get
            {
                return consumptionReportIDField;
            }
            set
            {
                consumptionReportIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return consumptionTypeField;
            }
            set
            {
                consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return consumptionTypeCodeField;
            }
            set
            {
                consumptionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return totalConsumedQuantityField;
            }
            set
            {
                totalConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
        {
            get
            {
                return periodField;
            }
            set
            {
                periodField = value;
            }
        }
    }
}