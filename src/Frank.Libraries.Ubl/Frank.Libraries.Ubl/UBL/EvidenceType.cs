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
[XmlRoot("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class EvidenceType
{
    private CandidateStatementType[] candidateStatementField;

    private DescriptionType[] descriptionField;

    private DocumentReferenceType documentReferenceField;

    private PartyType evidenceIssuingPartyField;

    private EvidenceTypeCodeType evidenceTypeCodeField;

    private IDType idField;

    private LanguageType languageField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EvidenceTypeCodeType EvidenceTypeCode
    {
        get => evidenceTypeCodeField;
        set => evidenceTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CandidateStatementType[] CandidateStatement
    {
        get => candidateStatementField;
        set => candidateStatementField = value;
    }

    /// <remarks />
    public PartyType EvidenceIssuingParty
    {
        get => evidenceIssuingPartyField;
        set => evidenceIssuingPartyField = value;
    }

    /// <remarks />
    public DocumentReferenceType DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public LanguageType Language
    {
        get => languageField;
        set => languageField = value;
    }
}