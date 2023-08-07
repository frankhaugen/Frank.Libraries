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
[XmlRoot("EvaluationCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EvaluationCriterionType
{
    private DescriptionType[] descriptionField;

    private PeriodType durationPeriodField;

    private EvaluationCriterionTypeCodeType evaluationCriterionTypeCodeField;

    private ExpressionCodeType expressionCodeField;

    private ExpressionType[] expressionField;

    private EvidenceType[] suggestedEvidenceField;

    private ThresholdAmountType thresholdAmountField;

    private ThresholdQuantityType thresholdQuantityField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EvaluationCriterionTypeCodeType EvaluationCriterionTypeCode
    {
        get => evaluationCriterionTypeCodeField;
        set => evaluationCriterionTypeCodeField = value;
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
    public ThresholdAmountType ThresholdAmount
    {
        get => thresholdAmountField;
        set => thresholdAmountField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThresholdQuantityType ThresholdQuantity
    {
        get => thresholdQuantityField;
        set => thresholdQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpressionCodeType ExpressionCode
    {
        get => expressionCodeField;
        set => expressionCodeField = value;
    }

    /// <remarks />
    [XmlElement("Expression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpressionType[] Expression
    {
        get => expressionField;
        set => expressionField = value;
    }

    /// <remarks />
    public PeriodType DurationPeriod
    {
        get => durationPeriodField;
        set => durationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("SuggestedEvidence")]
    public EvidenceType[] SuggestedEvidence
    {
        get => suggestedEvidenceField;
        set => suggestedEvidenceField = value;
    }
}