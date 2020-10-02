namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class MonetaryTotalType
    {

        private LineExtensionAmountType _lineExtensionAmountField;

        private TaxExclusiveAmountType _taxExclusiveAmountField;

        private TaxInclusiveAmountType _taxInclusiveAmountField;

        private AllowanceTotalAmountType _allowanceTotalAmountField;

        private ChargeTotalAmountType _chargeTotalAmountField;

        private PrepaidAmountType _prepaidAmountField;

        private PayableRoundingAmountType _payableRoundingAmountField;

        private PayableAmountType _payableAmountField;

        private PayableAlternativeAmountType _payableAlternativeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return _lineExtensionAmountField;
            }
            set
            {
                _lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExclusiveAmountType TaxExclusiveAmount
        {
            get
            {
                return _taxExclusiveAmountField;
            }
            set
            {
                _taxExclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxInclusiveAmountType TaxInclusiveAmount
        {
            get
            {
                return _taxInclusiveAmountField;
            }
            set
            {
                _taxInclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceTotalAmountType AllowanceTotalAmount
        {
            get
            {
                return _allowanceTotalAmountField;
            }
            set
            {
                _allowanceTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeTotalAmountType ChargeTotalAmount
        {
            get
            {
                return _chargeTotalAmountField;
            }
            set
            {
                _chargeTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidAmountType PrepaidAmount
        {
            get
            {
                return _prepaidAmountField;
            }
            set
            {
                _prepaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableRoundingAmountType PayableRoundingAmount
        {
            get
            {
                return _payableRoundingAmountField;
            }
            set
            {
                _payableRoundingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAmountType PayableAmount
        {
            get
            {
                return _payableAmountField;
            }
            set
            {
                _payableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAlternativeAmountType PayableAlternativeAmount
        {
            get
            {
                return _payableAlternativeAmountField;
            }
            set
            {
                _payableAlternativeAmountField = value;
            }
        }
    }
}