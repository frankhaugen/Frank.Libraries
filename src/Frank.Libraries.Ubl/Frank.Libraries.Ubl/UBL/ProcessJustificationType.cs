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
[XmlRoot("ProcessJustification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ProcessJustificationType
{
    private DescriptionType[] descriptionField;

    private PreviousCancellationReasonCodeType previousCancellationReasonCodeField;

    private ProcessReasonCodeType processReasonCodeField;

    private ProcessReasonType[] processReasonField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreviousCancellationReasonCodeType PreviousCancellationReasonCode
    {
        get => previousCancellationReasonCodeField;
        set => previousCancellationReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcessReasonCodeType ProcessReasonCode
    {
        get => processReasonCodeField;
        set => processReasonCodeField = value;
    }

    /// <remarks />
    [XmlElement("ProcessReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcessReasonType[] ProcessReason
    {
        get => processReasonField;
        set => processReasonField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }
}