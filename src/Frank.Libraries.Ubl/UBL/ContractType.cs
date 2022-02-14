namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ContractType
{

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NominationDateType nominationDateField;

    private NominationTimeType nominationTimeField;

    private ContractTypeCodeType contractTypeCodeField;

    private ContractTypeType contractType1Field;

    private NoteType[] noteField;

    private VersionIDType versionIDField;

    private DescriptionType[] descriptionField;

    private PeriodType validityPeriodField;

    private DocumentReferenceType[] contractDocumentReferenceField;

    private PeriodType nominationPeriodField;

    private DeliveryType contractualDeliveryField;

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
    public NominationDateType NominationDate
    {
        get
        {
            return this.nominationDateField;
        }
        set
        {
            this.nominationDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationTimeType NominationTime
    {
        get
        {
            return this.nominationTimeField;
        }
        set
        {
            this.nominationTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractTypeCodeType ContractTypeCode
    {
        get
        {
            return this.contractTypeCodeField;
        }
        set
        {
            this.contractTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractTypeType ContractType1
    {
        get
        {
            return this.contractType1Field;
        }
        set
        {
            this.contractType1Field = value;
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
    public PeriodType ValidityPeriod
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
    [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference")]
    public DocumentReferenceType[] ContractDocumentReference
    {
        get
        {
            return this.contractDocumentReferenceField;
        }
        set
        {
            this.contractDocumentReferenceField = value;
        }
    }

    /// <remarks/>
    public PeriodType NominationPeriod
    {
        get
        {
            return this.nominationPeriodField;
        }
        set
        {
            this.nominationPeriodField = value;
        }
    }

    /// <remarks/>
    public DeliveryType ContractualDelivery
    {
        get
        {
            return this.contractualDeliveryField;
        }
        set
        {
            this.contractualDeliveryField = value;
        }
    }
}