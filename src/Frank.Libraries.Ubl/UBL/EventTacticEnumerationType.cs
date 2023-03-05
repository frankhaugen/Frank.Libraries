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
[XmlRoot("EventTacticEnumeration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EventTacticEnumerationType
{
    private ConsumerIncentiveTacticTypeCodeType consumerIncentiveTacticTypeCodeField;

    private DisplayTacticTypeCodeType displayTacticTypeCodeField;

    private FeatureTacticTypeCodeType featureTacticTypeCodeField;

    private TradeItemPackingLabelingTypeCodeType tradeItemPackingLabelingTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsumerIncentiveTacticTypeCodeType ConsumerIncentiveTacticTypeCode
    {
        get => consumerIncentiveTacticTypeCodeField;
        set => consumerIncentiveTacticTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DisplayTacticTypeCodeType DisplayTacticTypeCode
    {
        get => displayTacticTypeCodeField;
        set => displayTacticTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeatureTacticTypeCodeType FeatureTacticTypeCode
    {
        get => featureTacticTypeCodeField;
        set => featureTacticTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TradeItemPackingLabelingTypeCodeType TradeItemPackingLabelingTypeCode
    {
        get => tradeItemPackingLabelingTypeCodeField;
        set => tradeItemPackingLabelingTypeCodeField = value;
    }
}