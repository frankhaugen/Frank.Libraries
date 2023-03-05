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
[XmlRoot("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class FrameworkAgreementType
{
    private PeriodType durationPeriodField;

    private ExpectedOperatorQuantityType expectedOperatorQuantityField;

    private FrequencyType[] frequencyField;

    private JustificationType[] justificationField;

    private MaximumOperatorQuantityType maximumOperatorQuantityField;

    private TenderRequirementType[] subsequentProcessTenderRequirementField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpectedOperatorQuantityType ExpectedOperatorQuantity
    {
        get => expectedOperatorQuantityField;
        set => expectedOperatorQuantityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumOperatorQuantityType MaximumOperatorQuantity
    {
        get => maximumOperatorQuantityField;
        set => maximumOperatorQuantityField = value;
    }

    /// <remarks />
    [XmlElement("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JustificationType[] Justification
    {
        get => justificationField;
        set => justificationField = value;
    }

    /// <remarks />
    [XmlElement("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FrequencyType[] Frequency
    {
        get => frequencyField;
        set => frequencyField = value;
    }

    /// <remarks />
    public PeriodType DurationPeriod
    {
        get => durationPeriodField;
        set => durationPeriodField = value;
    }

    /// <remarks />
    [XmlElement("SubsequentProcessTenderRequirement")]
    public TenderRequirementType[] SubsequentProcessTenderRequirement
    {
        get => subsequentProcessTenderRequirementField;
        set => subsequentProcessTenderRequirementField = value;
    }
}