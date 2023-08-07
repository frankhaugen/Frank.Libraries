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
[XmlRoot("PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PowerOfAttorneyType
{
    private PartyType agentPartyField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private DocumentReferenceType[] mandateDocumentReferenceField;

    private PartyType notaryPartyField;

    private PartyType[] witnessPartyField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get => issueDateField;
        set => issueDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get => issueTimeField;
        set => issueTimeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public PartyType NotaryParty
    {
        get => notaryPartyField;
        set => notaryPartyField = value;
    }

    /// <remarks />
    public PartyType AgentParty
    {
        get => agentPartyField;
        set => agentPartyField = value;
    }

    /// <remarks />
    [XmlElement("WitnessParty")]
    public PartyType[] WitnessParty
    {
        get => witnessPartyField;
        set => witnessPartyField = value;
    }

    /// <remarks />
    [XmlElement("MandateDocumentReference")]
    public DocumentReferenceType[] MandateDocumentReference
    {
        get => mandateDocumentReferenceField;
        set => mandateDocumentReferenceField = value;
    }
}