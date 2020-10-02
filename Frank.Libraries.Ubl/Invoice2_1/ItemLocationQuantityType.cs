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

        private LeadTimeMeasureType leadTimeMeasureField;

        private MinimumQuantityType minimumQuantityField;

        private MaximumQuantityType maximumQuantityField;

        private HazardousRiskIndicatorType hazardousRiskIndicatorField;

        private TradingRestrictionsType[] tradingRestrictionsField;

        private AddressType[] applicableTerritoryAddressField;

        private PriceType priceField;

        private DeliveryUnitType[] deliveryUnitField;

        private TaxCategoryType[] applicableTaxCategoryField;

        private PackageType packageField;

        private AllowanceChargeType[] allowanceChargeField;

        private DependentPriceReferenceType dependentPriceReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LeadTimeMeasureType LeadTimeMeasure
        {
            get
            {
                return leadTimeMeasureField;
            }
            set
            {
                leadTimeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity
        {
            get
            {
                return minimumQuantityField;
            }
            set
            {
                minimumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity
        {
            get
            {
                return maximumQuantityField;
            }
            set
            {
                maximumQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return hazardousRiskIndicatorField;
            }
            set
            {
                hazardousRiskIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradingRestrictionsType[] TradingRestrictions
        {
            get
            {
                return tradingRestrictionsField;
            }
            set
            {
                tradingRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress")]
        public AddressType[] ApplicableTerritoryAddress
        {
            get
            {
                return applicableTerritoryAddressField;
            }
            set
            {
                applicableTerritoryAddressField = value;
            }
        }

        /// <remarks/>
        public PriceType Price
        {
            get
            {
                return priceField;
            }
            set
            {
                priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit
        {
            get
            {
                return deliveryUnitField;
            }
            set
            {
                deliveryUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return applicableTaxCategoryField;
            }
            set
            {
                applicableTaxCategoryField = value;
            }
        }

        /// <remarks/>
        public PackageType Package
        {
            get
            {
                return packageField;
            }
            set
            {
                packageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return allowanceChargeField;
            }
            set
            {
                allowanceChargeField = value;
            }
        }

        /// <remarks/>
        public DependentPriceReferenceType DependentPriceReference
        {
            get
            {
                return dependentPriceReferenceField;
            }
            set
            {
                dependentPriceReferenceField = value;
            }
        }
    }
}