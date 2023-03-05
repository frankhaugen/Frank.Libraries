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
[XmlRoot("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class StatusType
{
    private ConditionCodeType conditionCodeField;

    private ConditionType1[] conditionField;

    private DescriptionType[] descriptionField;

    private IndicationIndicatorType indicationIndicatorField;

    private PercentType1 percentField;

    private ReferenceDateType referenceDateField;

    private ReferenceTimeType referenceTimeField;

    private ReliabilityPercentType reliabilityPercentField;

    private SequenceIDType sequenceIDField;

    private StatusReasonCodeType statusReasonCodeField;

    private StatusReasonType[] statusReasonField;

    private TextType2[] textField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionCodeType ConditionCode
    {
        get => conditionCodeField;
        set => conditionCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceDateType ReferenceDate
    {
        get => referenceDateField;
        set => referenceDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceTimeType ReferenceTime
    {
        get => referenceTimeField;
        set => referenceTimeField = value;
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
    public StatusReasonCodeType StatusReasonCode
    {
        get => statusReasonCodeField;
        set => statusReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StatusReasonType[] StatusReason
    {
        get => statusReasonField;
        set => statusReasonField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceIDType SequenceID
    {
        get => sequenceIDField;
        set => sequenceIDField = value;
    }

    /// <remarks />
    [XmlElement("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TextType2[] Text
    {
        get => textField;
        set => textField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IndicationIndicatorType IndicationIndicator
    {
        get => indicationIndicatorField;
        set => indicationIndicatorField = value;
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
    public ReliabilityPercentType ReliabilityPercent
    {
        get => reliabilityPercentField;
        set => reliabilityPercentField = value;
    }

    /// <remarks />
    [XmlElement("Condition")]
    public ConditionType1[] Condition
    {
        get => conditionField;
        set => conditionField = value;
    }
}