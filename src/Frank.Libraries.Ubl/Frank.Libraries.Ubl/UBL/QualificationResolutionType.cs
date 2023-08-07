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
[XmlRoot("QualificationResolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class QualificationResolutionType
{
    private AdmissionCodeType admissionCodeField;

    private ExclusionReasonType[] exclusionReasonField;

    private ProcurementProjectLotType procurementProjectLotField;

    private ResolutionDateType resolutionDateField;

    private ResolutionType[] resolutionField;

    private ResolutionTimeType resolutionTimeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdmissionCodeType AdmissionCode
    {
        get => admissionCodeField;
        set => admissionCodeField = value;
    }

    /// <remarks />
    [XmlElement("ExclusionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExclusionReasonType[] ExclusionReason
    {
        get => exclusionReasonField;
        set => exclusionReasonField = value;
    }

    /// <remarks />
    [XmlElement("Resolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionType[] Resolution
    {
        get => resolutionField;
        set => resolutionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionDateType ResolutionDate
    {
        get => resolutionDateField;
        set => resolutionDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ResolutionTimeType ResolutionTime
    {
        get => resolutionTimeField;
        set => resolutionTimeField = value;
    }

    /// <remarks />
    public ProcurementProjectLotType ProcurementProjectLot
    {
        get => procurementProjectLotField;
        set => procurementProjectLotField = value;
    }
}