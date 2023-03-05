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
[XmlRoot("EconomicOperatorShortList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EconomicOperatorShortListType
{
    private ExpectedQuantityType expectedQuantityField;

    private LimitationDescriptionType[] limitationDescriptionField;

    private MaximumQuantityType maximumQuantityField;

    private MinimumQuantityType minimumQuantityField;

    private PartyType[] preSelectedPartyField;

    /// <remarks />
    [XmlElement("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LimitationDescriptionType[] LimitationDescription
    {
        get => limitationDescriptionField;
        set => limitationDescriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpectedQuantityType ExpectedQuantity
    {
        get => expectedQuantityField;
        set => expectedQuantityField = value;
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
    public MinimumQuantityType MinimumQuantity
    {
        get => minimumQuantityField;
        set => minimumQuantityField = value;
    }

    /// <remarks />
    [XmlElement("PreSelectedParty")]
    public PartyType[] PreSelectedParty
    {
        get => preSelectedPartyField;
        set => preSelectedPartyField = value;
    }
}