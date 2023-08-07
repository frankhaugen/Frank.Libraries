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
[XmlRoot("AllowedSubcontractTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SubcontractTermsType
{
    private AmountType2 amountField;

    private DescriptionType[] descriptionField;

    private MaximumPercentType maximumPercentField;

    private MinimumPercentType minimumPercentField;

    private RateType1 rateField;

    private SubcontractingConditionsCodeType subcontractingConditionsCodeField;

    private UnknownPriceIndicatorType unknownPriceIndicatorField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RateType1 Rate
    {
        get => rateField;
        set => rateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UnknownPriceIndicatorType UnknownPriceIndicator
    {
        get => unknownPriceIndicatorField;
        set => unknownPriceIndicatorField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AmountType2 Amount
    {
        get => amountField;
        set => amountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubcontractingConditionsCodeType SubcontractingConditionsCode
    {
        get => subcontractingConditionsCodeField;
        set => subcontractingConditionsCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPercentType MaximumPercent
    {
        get => maximumPercentField;
        set => maximumPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumPercentType MinimumPercent
    {
        get => minimumPercentField;
        set => minimumPercentField = value;
    }
}