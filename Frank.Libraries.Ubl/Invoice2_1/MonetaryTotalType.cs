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

        private LineExtensionAmountType lineExtensionAmountField;

        private TaxExclusiveAmountType taxExclusiveAmountField;

        private TaxInclusiveAmountType taxInclusiveAmountField;

        private AllowanceTotalAmountType allowanceTotalAmountField;

        private ChargeTotalAmountType chargeTotalAmountField;

        private PrepaidAmountType prepaidAmountField;

        private PayableRoundingAmountType payableRoundingAmountField;

        private PayableAmountType payableAmountField;

        private PayableAlternativeAmountType payableAlternativeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return lineExtensionAmountField;
            }
            set
            {
                lineExtensionAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExclusiveAmountType TaxExclusiveAmount
        {
            get
            {
                return taxExclusiveAmountField;
            }
            set
            {
                taxExclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxInclusiveAmountType TaxInclusiveAmount
        {
            get
            {
                return taxInclusiveAmountField;
            }
            set
            {
                taxInclusiveAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AllowanceTotalAmountType AllowanceTotalAmount
        {
            get
            {
                return allowanceTotalAmountField;
            }
            set
            {
                allowanceTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChargeTotalAmountType ChargeTotalAmount
        {
            get
            {
                return chargeTotalAmountField;
            }
            set
            {
                chargeTotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrepaidAmountType PrepaidAmount
        {
            get
            {
                return prepaidAmountField;
            }
            set
            {
                prepaidAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableRoundingAmountType PayableRoundingAmount
        {
            get
            {
                return payableRoundingAmountField;
            }
            set
            {
                payableRoundingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAmountType PayableAmount
        {
            get
            {
                return payableAmountField;
            }
            set
            {
                payableAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayableAlternativeAmountType PayableAlternativeAmount
        {
            get
            {
                return payableAlternativeAmountField;
            }
            set
            {
                payableAlternativeAmountField = value;
            }
        }
    }
}