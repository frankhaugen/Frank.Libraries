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
[XmlRoot("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class DocumentReferenceType
{
    private AttachmentType attachmentField;

    private CopyIndicatorType copyIndicatorField;

    private DocumentDescriptionType[] documentDescriptionField;

    private DocumentStatusCodeType documentStatusCodeField;

    private DocumentTypeCodeType documentTypeCodeField;

    private DocumentTypeType documentTypeField;

    private IDType idField;

    private IssueDateType issueDateField;

    private PartyType issuerPartyField;

    private IssueTimeType issueTimeField;

    private LanguageIDType languageIDField;

    private LocaleCodeType localeCodeField;

    private ResultOfVerificationType resultOfVerificationField;

    private UUIDType uUIDField;

    private PeriodType validityPeriodField;

    private VersionIDType versionIDField;

    private XPathType[] xPathField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator
    {
        get => copyIndicatorField;
        set => copyIndicatorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentTypeCodeType DocumentTypeCode
    {
        get => documentTypeCodeField;
        set => documentTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentTypeType DocumentType
    {
        get => documentTypeField;
        set => documentTypeField = value;
    }

    /// <remarks />
    [XmlElement("XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public XPathType[] XPath
    {
        get => xPathField;
        set => xPathField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LanguageIDType LanguageID
    {
        get => languageIDField;
        set => languageIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LocaleCodeType LocaleCode
    {
        get => localeCodeField;
        set => localeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VersionIDType VersionID
    {
        get => versionIDField;
        set => versionIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentStatusCodeType DocumentStatusCode
    {
        get => documentStatusCodeField;
        set => documentStatusCodeField = value;
    }

    /// <remarks />
    [XmlElement("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentDescriptionType[] DocumentDescription
    {
        get => documentDescriptionField;
        set => documentDescriptionField = value;
    }

    /// <remarks />
    public AttachmentType Attachment
    {
        get => attachmentField;
        set => attachmentField = value;
    }

    /// <remarks />
    public PeriodType ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    public PartyType IssuerParty
    {
        get => issuerPartyField;
        set => issuerPartyField = value;
    }

    /// <remarks />
    public ResultOfVerificationType ResultOfVerification
    {
        get => resultOfVerificationField;
        set => resultOfVerificationField = value;
    }
}