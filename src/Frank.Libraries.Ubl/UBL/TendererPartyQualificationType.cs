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
[XmlRoot("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TendererPartyQualificationType
{
    private QualifyingPartyType[] additionalQualifyingPartyField;

    private ProcurementProjectLotType[] interestedProcurementProjectLotField;

    private QualifyingPartyType mainQualifyingPartyField;

    /// <remarks />
    [XmlElement("InterestedProcurementProjectLot")]
    public ProcurementProjectLotType[] InterestedProcurementProjectLot
    {
        get => interestedProcurementProjectLotField;
        set => interestedProcurementProjectLotField = value;
    }

    /// <remarks />
    public QualifyingPartyType MainQualifyingParty
    {
        get => mainQualifyingPartyField;
        set => mainQualifyingPartyField = value;
    }

    /// <remarks />
    [XmlElement("AdditionalQualifyingParty")]
    public QualifyingPartyType[] AdditionalQualifyingParty
    {
        get => additionalQualifyingPartyField;
        set => additionalQualifyingPartyField = value;
    }
}