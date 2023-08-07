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
[XmlRoot("TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class TradeFinancingType
{
    private ClauseType[] clauseField;

    private DocumentReferenceType contractDocumentReferenceField;

    private DocumentReferenceType[] documentReferenceField;

    private FinancialAccountType financingFinancialAccountField;

    private FinancingInstrumentCodeType financingInstrumentCodeField;

    private PartyType financingPartyField;

    private IDType idField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FinancingInstrumentCodeType FinancingInstrumentCode
    {
        get => financingInstrumentCodeField;
        set => financingInstrumentCodeField = value;
    }

    /// <remarks />
    public DocumentReferenceType ContractDocumentReference
    {
        get => contractDocumentReferenceField;
        set => contractDocumentReferenceField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public PartyType FinancingParty
    {
        get => financingPartyField;
        set => financingPartyField = value;
    }

    /// <remarks />
    public FinancialAccountType FinancingFinancialAccount
    {
        get => financingFinancialAccountField;
        set => financingFinancialAccountField = value;
    }

    /// <remarks />
    [XmlElement("Clause")]
    public ClauseType[] Clause
    {
        get => clauseField;
        set => clauseField = value;
    }
}