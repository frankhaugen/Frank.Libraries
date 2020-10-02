namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DeliveryTermsType
    {

        private IdType _idField;

        private SpecialTermsType[] _specialTermsField;

        private LossRiskResponsibilityCodeType _lossRiskResponsibilityCodeField;

        private LossRiskType[] _lossRiskField;

        private AmountType2 _amountField;

        private LocationType1 _deliveryLocationField;

        private AllowanceChargeType _allowanceChargeField;

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
        [System.Xml.Serialization.XmlElementAttribute("SpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SpecialTermsType[] SpecialTerms
        {
            get
            {
                return _specialTermsField;
            }
            set
            {
                _specialTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LossRiskResponsibilityCodeType LossRiskResponsibilityCode
        {
            get
            {
                return _lossRiskResponsibilityCodeField;
            }
            set
            {
                _lossRiskResponsibilityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LossRisk", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LossRiskType[] LossRisk
        {
            get
            {
                return _lossRiskField;
            }
            set
            {
                _lossRiskField = value;
            }
        }

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
        public LocationType1 DeliveryLocation
        {
            get
            {
                return _deliveryLocationField;
            }
            set
            {
                _deliveryLocationField = value;
            }
        }

        /// <remarks/>
        public AllowanceChargeType AllowanceCharge
        {
            get
            {
                return _allowanceChargeField;
            }
            set
            {
                _allowanceChargeField = value;
            }
        }
    }
}