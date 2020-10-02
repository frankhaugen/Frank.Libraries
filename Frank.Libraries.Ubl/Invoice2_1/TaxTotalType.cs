namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TaxTotalType
    {

        private TaxAmountType _taxAmountField;

        private RoundingAmountType _roundingAmountField;

        private TaxEvidenceIndicatorType _taxEvidenceIndicatorField;

        private TaxIncludedIndicatorType _taxIncludedIndicatorField;

        private TaxSubtotalType[] _taxSubtotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmountType TaxAmount
        {
            get
            {
                return _taxAmountField;
            }
            set
            {
                _taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoundingAmountType RoundingAmount
        {
            get
            {
                return _roundingAmountField;
            }
            set
            {
                _roundingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEvidenceIndicatorType TaxEvidenceIndicator
        {
            get
            {
                return _taxEvidenceIndicatorField;
            }
            set
            {
                _taxEvidenceIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return _taxIncludedIndicatorField;
            }
            set
            {
                _taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxSubtotal")]
        public TaxSubtotalType[] TaxSubtotal
        {
            get
            {
                return _taxSubtotalField;
            }
            set
            {
                _taxSubtotalField = value;
            }
        }
    }
}