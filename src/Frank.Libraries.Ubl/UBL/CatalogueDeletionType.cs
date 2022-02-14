namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueDeletion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2", IsNullable = false)]
public partial class CatalogueDeletionType
{

    private UBLExtensionType[] uBLExtensionsField;

    private UBLVersionIDType uBLVersionIDField;

    private CustomizationIDType customizationIDField;

    private ProfileIDType profileIDField;

    private ProfileExecutionIDType profileExecutionIDField;

    private IDType idField;

    private UUIDType uUIDField;

    private NameType1 nameField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private EffectiveDateType effectiveDateField;

    private EffectiveTimeType effectiveTimeField;

    private NoteType[] noteField;

    private VersionIDType versionIDField;

    private DescriptionType[] descriptionField;

    private PeriodType[] validityPeriodField;

    private CatalogueReferenceType deletedCatalogueReferenceField;

    private ContractType[] referencedContractField;

    private SignatureType[] signatureField;

    private PartyType receiverPartyField;

    private PartyType providerPartyField;

    private SupplierPartyType sellerSupplierPartyField;

    private CustomerPartyType contractorCustomerPartyField;

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
    public NameType1 Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EffectiveDateType EffectiveDate
    {
        get
        {
            return this.effectiveDateField;
        }
        set
        {
            this.effectiveDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EffectiveTimeType EffectiveTime
    {
        get
        {
            return this.effectiveTimeField;
        }
        set
        {
            this.effectiveTimeField = value;
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
    public VersionIDType VersionID
    {
        get
        {
            return this.versionIDField;
        }
        set
        {
            this.versionIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] ValidityPeriod
    {
        get
        {
            return this.validityPeriodField;
        }
        set
        {
            this.validityPeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CatalogueReferenceType DeletedCatalogueReference
    {
        get
        {
            return this.deletedCatalogueReferenceField;
        }
        set
        {
            this.deletedCatalogueReferenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ContractType[] ReferencedContract
    {
        get
        {
            return this.referencedContractField;
        }
        set
        {
            this.referencedContractField = value;
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
    public PartyType ProviderParty
    {
        get
        {
            return this.providerPartyField;
        }
        set
        {
            this.providerPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            return this.sellerSupplierPartyField;
        }
        set
        {
            this.sellerSupplierPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType ContractorCustomerParty
    {
        get
        {
            return this.contractorCustomerPartyField;
        }
        set
        {
            this.contractorCustomerPartyField = value;
        }
    }
}