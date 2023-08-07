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
[XmlRoot("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TenderPreparationType
{
    private DescriptionType[] descriptionField;

    private TenderRequirementType[] documentTenderRequirementField;

    private OpenTenderIDType openTenderIDField;

    private ProcurementProjectLotType[] procurementProjectLotField;

    private TenderEnvelopeIDType tenderEnvelopeIDField;

    private TenderEnvelopeTypeCodeType tenderEnvelopeTypeCodeField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeIDType TenderEnvelopeID
    {
        get => tenderEnvelopeIDField;
        set => tenderEnvelopeIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode
    {
        get => tenderEnvelopeTypeCodeField;
        set => tenderEnvelopeTypeCodeField = value;
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
    public OpenTenderIDType OpenTenderID
    {
        get => openTenderIDField;
        set => openTenderIDField = value;
    }

    /// <remarks />
    [XmlElement("ProcurementProjectLot")]
    public ProcurementProjectLotType[] ProcurementProjectLot
    {
        get => procurementProjectLotField;
        set => procurementProjectLotField = value;
    }

    /// <remarks />
    [XmlElement("DocumentTenderRequirement")]
    public TenderRequirementType[] DocumentTenderRequirement
    {
        get => documentTenderRequirementField;
        set => documentTenderRequirementField = value;
    }
}