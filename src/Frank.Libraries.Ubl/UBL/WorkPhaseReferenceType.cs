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
[XmlRoot("WorkPhaseReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class WorkPhaseReferenceType
{
    private EndDateType endDateField;

    private IDType idField;

    private ProgressPercentType progressPercentField;

    private StartDateType startDateField;

    private DocumentReferenceType[] workOrderDocumentReferenceField;

    private WorkPhaseCodeType workPhaseCodeField;

    private WorkPhaseType[] workPhaseField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WorkPhaseCodeType WorkPhaseCode
    {
        get => workPhaseCodeField;
        set => workPhaseCodeField = value;
    }

    /// <remarks />
    [XmlElement("WorkPhase", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WorkPhaseType[] WorkPhase
    {
        get => workPhaseField;
        set => workPhaseField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProgressPercentType ProgressPercent
    {
        get => progressPercentField;
        set => progressPercentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StartDateType StartDate
    {
        get => startDateField;
        set => startDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EndDateType EndDate
    {
        get => endDateField;
        set => endDateField = value;
    }

    /// <remarks />
    [XmlElement("WorkOrderDocumentReference")]
    public DocumentReferenceType[] WorkOrderDocumentReference
    {
        get => workOrderDocumentReferenceField;
        set => workOrderDocumentReferenceField = value;
    }
}