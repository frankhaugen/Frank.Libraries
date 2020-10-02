namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ApplicableTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TaxCategoryType
    {

        private IDType idField;

        private NameType1 nameField;

        private PercentType1 percentField;

        private BaseUnitMeasureType baseUnitMeasureField;

        private PerUnitAmountType perUnitAmountField;

        private TaxExemptionReasonCodeType taxExemptionReasonCodeField;

        private TaxExemptionReasonType[] taxExemptionReasonField;

        private TierRangeType tierRangeField;

        private TierRatePercentType tierRatePercentField;

        private TaxSchemeType taxSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return percentField;
            }
            set
            {
                percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseUnitMeasureType BaseUnitMeasure
        {
            get
            {
                return baseUnitMeasureField;
            }
            set
            {
                baseUnitMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return perUnitAmountField;
            }
            set
            {
                perUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExemptionReasonCodeType TaxExemptionReasonCode
        {
            get
            {
                return taxExemptionReasonCodeField;
            }
            set
            {
                taxExemptionReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExemptionReasonType[] TaxExemptionReason
        {
            get
            {
                return taxExemptionReasonField;
            }
            set
            {
                taxExemptionReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRangeType TierRange
        {
            get
            {
                return tierRangeField;
            }
            set
            {
                tierRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRatePercentType TierRatePercent
        {
            get
            {
                return tierRatePercentField;
            }
            set
            {
                tierRatePercentField = value;
            }
        }

        /// <remarks/>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return taxSchemeField;
            }
            set
            {
                taxSchemeField = value;
            }
        }
    }
}