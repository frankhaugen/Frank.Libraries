namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("FinalFinancialGuarantee", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class FinancialGuaranteeType
    {

        private GuaranteeTypeCodeType _guaranteeTypeCodeField;

        private DescriptionType[] _descriptionField;

        private LiabilityAmountType _liabilityAmountField;

        private AmountRateType _amountRateField;

        private PeriodType _constitutionPeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GuaranteeTypeCodeType GuaranteeTypeCode
        {
            get
            {
                return _guaranteeTypeCodeField;
            }
            set
            {
                _guaranteeTypeCodeField = value;
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
        public LiabilityAmountType LiabilityAmount
        {
            get
            {
                return _liabilityAmountField;
            }
            set
            {
                _liabilityAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountRateType AmountRate
        {
            get
            {
                return _amountRateField;
            }
            set
            {
                _amountRateField = value;
            }
        }

        /// <remarks/>
        public PeriodType ConstitutionPeriod
        {
            get
            {
                return _constitutionPeriodField;
            }
            set
            {
                _constitutionPeriodField = value;
            }
        }
    }
}