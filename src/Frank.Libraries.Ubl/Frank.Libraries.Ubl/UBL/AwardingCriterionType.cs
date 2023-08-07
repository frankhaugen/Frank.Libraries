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
[XmlRoot("AwardingCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AwardingCriterionType
{
    private AwardingCriterionTypeCodeType awardingCriterionTypeCodeField;

    private CalculationExpressionCodeType calculationExpressionCodeField;

    private CalculationExpressionType[] calculationExpressionField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private MaximumAmountType maximumAmountField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumAmountType minimumAmountField;

    private MinimumImprovementBidType[] minimumImprovementBidField;

    private MinimumQuantityType minimumQuantityField;

    private AwardingCriterionType[] subordinateAwardingCriterionField;

    private WeightType[] weightField;

    private WeightNumericType weightNumericField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AwardingCriterionTypeCodeType AwardingCriterionTypeCode
    {
        get => awardingCriterionTypeCodeField;
        set => awardingCriterionTypeCodeField = value;
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
    public WeightNumericType WeightNumeric
    {
        get => weightNumericField;
        set => weightNumericField = value;
    }

    /// <remarks />
    [XmlElement("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WeightType[] Weight
    {
        get => weightField;
        set => weightField = value;
    }

    /// <remarks />
    [XmlElement("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationExpressionType[] CalculationExpression
    {
        get => calculationExpressionField;
        set => calculationExpressionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationExpressionCodeType CalculationExpressionCode
    {
        get => calculationExpressionCodeField;
        set => calculationExpressionCodeField = value;
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
    public MinimumAmountType MinimumAmount
    {
        get => minimumAmountField;
        set => minimumAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumAmountType MaximumAmount
    {
        get => maximumAmountField;
        set => maximumAmountField = value;
    }

    /// <remarks />
    [XmlElement("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumImprovementBidType[] MinimumImprovementBid
    {
        get => minimumImprovementBidField;
        set => minimumImprovementBidField = value;
    }

    /// <remarks />
    [XmlElement("SubordinateAwardingCriterion")]
    public AwardingCriterionType[] SubordinateAwardingCriterion
    {
        get => subordinateAwardingCriterionField;
        set => subordinateAwardingCriterionField = value;
    }
}