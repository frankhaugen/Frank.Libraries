using System;
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
[XmlRoot("ApplicableTaxCategory", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TaxCategoryType
{
    private BaseUnitMeasureType baseUnitMeasureField;

    private IDType idField;

    private NameType1 nameField;

    private PercentType1 percentField;

    private PerUnitAmountType perUnitAmountField;

    private TaxExemptionReasonCodeType taxExemptionReasonCodeField;

    private TaxExemptionReasonType[] taxExemptionReasonField;

    private TaxSchemeType taxSchemeField;

    private TierRangeType tierRangeField;

    private TierRatePercentType tierRatePercentField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PercentType1 Percent
    {
        get => percentField;
        set => percentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BaseUnitMeasureType BaseUnitMeasure
    {
        get => baseUnitMeasureField;
        set => baseUnitMeasureField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerUnitAmountType PerUnitAmount
    {
        get => perUnitAmountField;
        set => perUnitAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxExemptionReasonCodeType TaxExemptionReasonCode
    {
        get => taxExemptionReasonCodeField;
        set => taxExemptionReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("TaxExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxExemptionReasonType[] TaxExemptionReason
    {
        get => taxExemptionReasonField;
        set => taxExemptionReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRangeType TierRange
    {
        get => tierRangeField;
        set => tierRangeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TierRatePercentType TierRatePercent
    {
        get => tierRatePercentField;
        set => tierRatePercentField = value;
    }

    /// <remarks />
    public TaxSchemeType TaxScheme
    {
        get => taxSchemeField;
        set => taxSchemeField = value;
    }
}