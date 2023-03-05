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
[XmlRoot("AdditionalDocumentResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DocumentResponseType
{
    private DocumentReferenceType[] documentReferenceField;

    private PartyType issuerPartyField;

    private LineResponseType[] lineResponseField;

    private PartyType recipientPartyField;

    private ResponseType responseField;

    /// <remarks />
    public ResponseType Response
    {
        get => responseField;
        set => responseField = value;
    }

    /// <remarks />
    [XmlElement("DocumentReference")]
    public DocumentReferenceType[] DocumentReference
    {
        get => documentReferenceField;
        set => documentReferenceField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }

    /// <remarks />
    public PartyType RecipientParty
    {
        get => recipientPartyField;
        set => recipientPartyField = value;
    }

    /// <remarks />
    [XmlElement("LineResponse")]
    public LineResponseType[] LineResponse
    {
        get => lineResponseField;
        set => lineResponseField = value;
    }
}