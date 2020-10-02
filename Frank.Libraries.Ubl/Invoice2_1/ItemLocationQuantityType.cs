namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemLocationQuantityType
    {

        private LeadTimeMeasureType _leadTimeMeasureField;

        private MinimumQuantityType _minimumQuantityField;

        private MaximumQuantityType _maximumQuantityField;

        private HazardousRiskIndicatorType _hazardousRiskIndicatorField;

        private TradingRestrictionsType[] _tradingRestrictionsField;

        private AddressType[] _applicableTerritoryAddressField;

        private PriceType _priceField;

        private DeliveryUnitType[] _deliveryUnitField;

        private TaxCategoryType[] _applicableTaxCategoryField;

        private PackageType _packageField;

        private AllowanceChargeType[] _allowanceChargeField;

        private DependentPriceReferenceType _dependentPriceReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LeadTimeMeasureType LeadTimeMeasure
        {
            get
            {
                return _leadTimeMeasureField;
            }
            set
            {
                _leadTimeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return _minimumQuantityField;
            }
            set
            {
                _minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return _maximumQuantityField;
            }
            set
            {
                _maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicatorField;
            }
            set
            {
                _hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradingRestrictionsType[] TradingRestrictions
        {
            get
            {
                return _tradingRestrictionsField;
            }
            set
            {
                _tradingRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress")]
        public AddressType[] ApplicableTerritoryAddress
        {
            get
            {
                return _applicableTerritoryAddressField;
            }
            set
            {
                _applicableTerritoryAddressField = value;
            }
        }

        /// <remarks/>
        public PriceType Price
        {
            get
            {
                return _priceField;
            }
            set
            {
                _priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return _deliveryUnitField;
            }
            set
            {
                _deliveryUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return _applicableTaxCategoryField;
            }
            set
            {
                _applicableTaxCategoryField = value;
            }
        }

        /// <remarks/>
        public PackageType Package
        {
            get
            {
                return _packageField;
            }
            set
            {
                _packageField = value;
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
        public DependentPriceReferenceType DependentPriceReference
        {
            get
            {
                return _dependentPriceReferenceField;
            }
            set
            {
                _dependentPriceReferenceField = value;
            }
        }
    }
}