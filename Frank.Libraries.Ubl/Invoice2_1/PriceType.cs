namespace Frank.Libraries.Ubl.Invoice2_1
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

        private PriceAmountType _priceAmountField;

        private BaseQuantityType _baseQuantityField;

        private PriceChangeReasonType[] _priceChangeReasonField;

        private PriceTypeCodeType _priceTypeCodeField;

        private PriceTypeType _priceType1Field;

        private OrderableUnitFactorRateType _orderableUnitFactorRateField;

        private PeriodType[] _validityPeriodField;

        private PriceListType _priceListField;

        private AllowanceChargeType[] _allowanceChargeField;

        private ExchangeRateType _pricingExchangeRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType PriceAmount
        {
            get
            {
                return _priceAmountField;
            }
            set
            {
                _priceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseQuantityType BaseQuantity
        {
            get
            {
                return _baseQuantityField;
            }
            set
            {
                _baseQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceChangeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceChangeReasonType[] PriceChangeReason
        {
            get
            {
                return _priceChangeReasonField;
            }
            set
            {
                _priceChangeReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeCodeType PriceTypeCode
        {
            get
            {
                return _priceTypeCodeField;
            }
            set
            {
                _priceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeType PriceType1
        {
            get
            {
                return _priceType1Field;
            }
            set
            {
                _priceType1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitFactorRateType OrderableUnitFactorRate
        {
            get
            {
                return _orderableUnitFactorRateField;
            }
            set
            {
                _orderableUnitFactorRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
        public PeriodType[] ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PriceListType PriceList
        {
            get
            {
                return _priceListField;
            }
            set
            {
                _priceListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
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

        /// <remarks/>
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return _pricingExchangeRateField;
            }
            set
            {
                _pricingExchangeRateField = value;
            }
        }
    }
}