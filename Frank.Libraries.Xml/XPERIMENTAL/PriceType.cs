namespace Bilagos.DocumentProcessor.UBL.Document
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PriceType
    {

        private PriceAmountType priceAmountField;

        private BaseQuantityType baseQuantityField;

        private PriceChangeReasonType[] priceChangeReasonField;

        private PriceTypeCodeType priceTypeCodeField;

        private PriceTypeType priceType1Field;

        private OrderableUnitFactorRateType orderableUnitFactorRateField;

        private PeriodType[] validityPeriodField;

        private PriceListType priceListField;

        private AllowanceChargeType[] allowanceChargeField;

        private ExchangeRateType pricingExchangeRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType PriceAmount
        {
            get
            {
                return this.priceAmountField;
            }
            set
            {
                this.priceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseQuantityType BaseQuantity
        {
            get
            {
                return this.baseQuantityField;
            }
            set
            {
                this.baseQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceChangeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceChangeReasonType[] PriceChangeReason
        {
            get
            {
                return this.priceChangeReasonField;
            }
            set
            {
                this.priceChangeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeCodeType PriceTypeCode
        {
            get
            {
                return this.priceTypeCodeField;
            }
            set
            {
                this.priceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeType PriceType1
        {
            get
            {
                return this.priceType1Field;
            }
            set
            {
                this.priceType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitFactorRateType OrderableUnitFactorRate
        {
            get
            {
                return this.orderableUnitFactorRateField;
            }
            set
            {
                this.orderableUnitFactorRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return this.validityPeriodField;
            }
            set
            {
                this.validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PriceListType PriceList
        {
            get
            {
                return this.priceListField;
            }
            set
            {
                this.priceListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }

        /// <remarks/>
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return this.pricingExchangeRateField;
            }
            set
            {
                this.pricingExchangeRateField = value;
            }
        }
    }
}