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
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseUnitMeasureType BaseUnitMeasure
        {
            get
            {
                return this.baseUnitMeasureField;
            }
            set
            {
                this.baseUnitMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return this.perUnitAmountField;
            }
            set
            {
                this.perUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExemptionReasonCodeType TaxExemptionReasonCode
        {
            get
            {
                return this.taxExemptionReasonCodeField;
            }
            set
            {
                this.taxExemptionReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxExemptionReasonType[] TaxExemptionReason
        {
            get
            {
                return this.taxExemptionReasonField;
            }
            set
            {
                this.taxExemptionReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRangeType TierRange
        {
            get
            {
                return this.tierRangeField;
            }
            set
            {
                this.tierRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TierRatePercentType TierRatePercent
        {
            get
            {
                return this.tierRatePercentField;
            }
            set
            {
                this.tierRatePercentField = value;
            }
        }

        /// <remarks/>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return this.taxSchemeField;
            }
            set
            {
                this.taxSchemeField = value;
            }
        }
    }
}