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
[XmlRoot("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ResponseType
{
    private DescriptionType[] descriptionField;

    private EffectiveDateType effectiveDateField;

    private EffectiveTimeType effectiveTimeField;

    private ReferenceIDType referenceIDField;

    private ResponseCodeType responseCodeField;

    private StatusType[] statusField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReferenceIDType ReferenceID
    {
        get => referenceIDField;
        set => referenceIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResponseCodeType ResponseCode
    {
        get => responseCodeField;
        set => responseCodeField = value;
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
    public EffectiveDateType EffectiveDate
    {
        get => effectiveDateField;
        set => effectiveDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EffectiveTimeType EffectiveTime
    {
        get => effectiveTimeField;
        set => effectiveTimeField = value;
    }

    /// <remarks />
    [XmlElement("Status")]
    public StatusType[] Status
    {
        get => statusField;
        set => statusField = value;
    }
}