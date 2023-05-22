using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("AlternativeConditionPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PriceType
{
    private AllowanceChargeType[] allowanceChargeField;

    private BaseQuantityType baseQuantityField;

    private OrderableUnitFactorRateType orderableUnitFactorRateField;

    private PriceAmountType priceAmountField;

    private PriceChangeReasonType[] priceChangeReasonField;

    private PriceListType priceListField;

    private PriceTypeType priceType1Field;

    private PriceTypeCodeType priceTypeCodeField;

    private ExchangeRateType pricingExchangeRateField;

    private PeriodType[] validityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceAmountType PriceAmount
    {
        get => priceAmountField;
        set => priceAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BaseQuantityType BaseQuantity
    {
        get => baseQuantityField;
        set => baseQuantityField = value;
    }

    /// <remarks />
    [XmlElement("PriceChangeReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceChangeReasonType[] PriceChangeReason
    {
        get => priceChangeReasonField;
        set => priceChangeReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceTypeCodeType PriceTypeCode
    {
        get => priceTypeCodeField;
        set => priceTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("PriceType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PriceTypeType PriceType1
    {
        get => priceType1Field;
        set => priceType1Field = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderableUnitFactorRateType OrderableUnitFactorRate
    {
        get => orderableUnitFactorRateField;
        set => orderableUnitFactorRateField = value;
    }

    /// <remarks />
    [XmlElement("ValidityPeriod")]
    public PeriodType[] ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    public PriceListType PriceList
    {
        get => priceListField;
        set => priceListField = value;
    }

    /// <remarks />
    [XmlElement("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge
    {
        get => allowanceChargeField;
        set => allowanceChargeField = value;
    }

    /// <remarks />
    public ExchangeRateType PricingExchangeRate
    {
        get => pricingExchangeRateField;
        set => pricingExchangeRateField = value;
    }
}