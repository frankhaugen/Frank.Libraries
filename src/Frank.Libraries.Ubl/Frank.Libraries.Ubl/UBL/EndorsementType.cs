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
[XmlRoot("EmbassyEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EndorsementType
{
    private ApprovalStatusType approvalStatusField;

    private DocumentIDType documentIDField;

    private EndorserPartyType endorserPartyField;

    private RemarksType[] remarksField;

    private SignatureType[] signatureField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentIDType DocumentID
    {
        get => documentIDField;
        set => documentIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ApprovalStatusType ApprovalStatus
    {
        get => approvalStatusField;
        set => approvalStatusField = value;
    }

    /// <remarks />
    [XmlElement("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks
    {
        get => remarksField;
        set => remarksField = value;
    }

    /// <remarks />
    public EndorserPartyType EndorserParty
    {
        get => endorserPartyField;
        set => endorserPartyField = value;
    }

    /// <remarks />
    [XmlElement("Signature")]
    public SignatureType[] Signature
    {
        get => signatureField;
        set => signatureField = value;
    }
}