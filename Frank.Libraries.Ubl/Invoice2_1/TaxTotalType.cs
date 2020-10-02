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

        private TaxAmountType taxAmountField;

        private RoundingAmountType roundingAmountField;

        private TaxEvidenceIndicatorType taxEvidenceIndicatorField;

        private TaxIncludedIndicatorType taxIncludedIndicatorField;

        private TaxSubtotalType[] taxSubtotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxAmountType TaxAmount
        {
            get
            {
                return taxAmountField;
            }
            set
            {
                taxAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoundingAmountType RoundingAmount
        {
            get
            {
                return roundingAmountField;
            }
            set
            {
                roundingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEvidenceIndicatorType TaxEvidenceIndicator
        {
            get
            {
                return taxEvidenceIndicatorField;
            }
            set
            {
                taxEvidenceIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return taxIncludedIndicatorField;
            }
            set
            {
                taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxSubtotal")]
        public TaxSubtotalType[] TaxSubtotal
        {
            get
            {
                return taxSubtotalField;
            }
            set
            {
                taxSubtotalField = value;
            }
        }
    }
}