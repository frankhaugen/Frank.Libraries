namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DutyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DutyType1
    {

        private AmountType2 _amountField;

        private DutyType _dutyField;

        private DutyCodeType _dutyCodeField;

        private TaxCategoryType _taxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType2 Amount
        {
            get
            {
                return _amountField;
            }
            set
            {
                _amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DutyType Duty
        {
            get
            {
                return _dutyField;
            }
            set
            {
                _dutyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DutyCodeType DutyCode
        {
            get
            {
                return _dutyCodeField;
            }
            set
            {
                _dutyCodeField = value;
            }
        }

        /// <remarks/>
        public TaxCategoryType TaxCategory
        {
            get
            {
                return _taxCategoryField;
            }
            set
            {
                _taxCategoryField = value;
            }
        }
    }
}