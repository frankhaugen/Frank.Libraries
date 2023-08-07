using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ItemLocationQuantityType
{
    private AllowanceChargeType[] allowanceChargeField;

    private TaxCategoryType[] applicableTaxCategoryField;

    private AddressType[] applicableTerritoryAddressField;

    private DeliveryUnitType[] deliveryUnitField;

    private DependentPriceReferenceType dependentPriceReferenceField;

    private HazardousRiskIndicatorType hazardousRiskIndicatorField;

    private LeadTimeMeasureType leadTimeMeasureField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumQuantityType minimumQuantityField;

    private PackageType packageField;

    private PriceType priceField;

    private TradingRestrictionsType[] tradingRestrictionsField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LeadTimeMeasureType LeadTimeMeasure
    {
        get => leadTimeMeasureField;
        set => leadTimeMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity
    {
        get => minimumQuantityField;
        set => minimumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity
    {
        get => maximumQuantityField;
        set => maximumQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator
    {
        get => hazardousRiskIndicatorField;
        set => hazardousRiskIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TradingRestrictionsType[] TradingRestrictions
    {
        get => tradingRestrictionsField;
        set => tradingRestrictionsField = value;
    }

    /// <remarks />
    [XmlElement("ApplicableTerritoryAddress")]
    public AddressType[] ApplicableTerritoryAddress
    {
        get => applicableTerritoryAddressField;
        set => applicableTerritoryAddressField = value;
    }

    /// <remarks />
    public PriceType Price
    {
        get => priceField;
        set => priceField = value;
    }

    /// <remarks />
    [XmlElement("DeliveryUnit")]
    public DeliveryUnitType[] DeliveryUnit
    {
        get => deliveryUnitField;
        set => deliveryUnitField = value;
    }

    /// <remarks />
    [XmlElement("ApplicableTaxCategory")]
    public TaxCategoryType[] ApplicableTaxCategory
    {
        get => applicableTaxCategoryField;
        set => applicableTaxCategoryField = value;
    }

    /// <remarks />
    public PackageType Package
    {
        get => packageField;
        set => packageField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    public DependentPriceReferenceType DependentPriceReference
    {
        get => dependentPriceReferenceField;
        set => dependentPriceReferenceField = value;
    }
}