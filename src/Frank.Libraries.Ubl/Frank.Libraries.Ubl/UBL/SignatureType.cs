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
[XmlRoot("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class SignatureType
{
    private CanonicalizationMethodType canonicalizationMethodField;

    private AttachmentType digitalSignatureAttachmentField;

    private IDType idField;

    private NoteType[] noteField;

    private DocumentReferenceType originalDocumentReferenceField;

    private PartyType signatoryPartyField;

    private SignatureMethodType signatureMethodField;

    private ValidationDateType validationDateField;

    private ValidationTimeType validationTimeField;

    private ValidatorIDType validatorIDField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get => noteField;
        set => noteField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidationDateType ValidationDate
    {
        get => validationDateField;
        set => validationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidationTimeType ValidationTime
    {
        get => validationTimeField;
        set => validationTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValidatorIDType ValidatorID
    {
        get => validatorIDField;
        set => validatorIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CanonicalizationMethodType CanonicalizationMethod
    {
        get => canonicalizationMethodField;
        set => canonicalizationMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SignatureMethodType SignatureMethod
    {
        get => signatureMethodField;
        set => signatureMethodField = value;
    }

    /// <remarks />
    public PartyType SignatoryParty
    {
        get => signatoryPartyField;
        set => signatoryPartyField = value;
    }

    /// <remarks />
    public AttachmentType DigitalSignatureAttachment
    {
        get => digitalSignatureAttachmentField;
        set => digitalSignatureAttachmentField = value;
    }

    /// <remarks />
    public DocumentReferenceType OriginalDocumentReference
    {
        get => originalDocumentReferenceField;
        set => originalDocumentReferenceField = value;
    }
}