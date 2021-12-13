namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2")]
[System.Xml.Serialization.XmlRootAttribute("AttachedDocument", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2", IsNullable = false)]
public partial class AttachedDocumentType
{

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private CustomizationIDType customizationIDField;

    private ProfileIDType profileIDField;

    private ProfileExecutionIDType profileExecutionIDField;

    private IDType idField;

    private UUIDType uUIDField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NoteType[] noteField;

    private DocumentTypeCodeType documentTypeCodeField;

    private DocumentTypeType documentTypeField;

    private ParentDocumentIDType parentDocumentIDField;

    private ParentDocumentTypeCodeType parentDocumentTypeCodeField;

    private ParentDocumentVersionIDType parentDocumentVersionIDField;

    private SignatureType[] signatureField;

    private PartyType senderPartyField;

    private PartyType receiverPartyField;

    private AttachmentType attachmentField;

    private LineReferenceType[] parentDocumentLineReferenceField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions
    {
        get
        {
            return this.uBLExtensionsField;
        }
        set
        {
            this.uBLExtensionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID
    {
        get
        {
            return this.uBLVersionIDField;
        }
        set
        {
            this.uBLVersionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID
    {
        get
        {
            return this.customizationIDField;
        }
        set
        {
            this.customizationIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID
    {
        get
        {
            return this.profileIDField;
        }
        set
        {
            this.profileIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID
    {
        get
        {
            return this.profileExecutionIDField;
        }
        set
        {
            this.profileExecutionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID
    {
        get
        {
            return this.uUIDField;
        }
        set
        {
            this.uUIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime
    {
        get
        {
            return this.issueTimeField;
        }
        set
        {
            this.issueTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentTypeCodeType DocumentTypeCode
    {
        get
        {
            return this.documentTypeCodeField;
        }
        set
        {
            this.documentTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentTypeType DocumentType
    {
        get
        {
            return this.documentTypeField;
        }
        set
        {
            this.documentTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParentDocumentIDType ParentDocumentID
    {
        get
        {
            return this.parentDocumentIDField;
        }
        set
        {
            this.parentDocumentIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParentDocumentTypeCodeType ParentDocumentTypeCode
    {
        get
        {
            return this.parentDocumentTypeCodeField;
        }
        set
        {
            this.parentDocumentTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParentDocumentVersionIDType ParentDocumentVersionID
    {
        get
        {
            return this.parentDocumentVersionIDField;
        }
        set
        {
            this.parentDocumentVersionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType SenderParty
    {
        get
        {
            return this.senderPartyField;
        }
        set
        {
            this.senderPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType ReceiverParty
    {
        get
        {
            return this.receiverPartyField;
        }
        set
        {
            this.receiverPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public AttachmentType Attachment
    {
        get
        {
            return this.attachmentField;
        }
        set
        {
            this.attachmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ParentDocumentLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public LineReferenceType[] ParentDocumentLineReference
    {
        get
        {
            return this.parentDocumentLineReferenceField;
        }
        set
        {
            this.parentDocumentLineReferenceField = value;
        }
    }
}