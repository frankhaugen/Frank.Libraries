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
[XmlRoot("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ContractType
{
    private DocumentReferenceType[] contractDocumentReferenceField;

    private ContractTypeType contractType1Field;

    private ContractTypeCodeType contractTypeCodeField;

    private DeliveryType contractualDeliveryField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private IssueDateType issueDateField;

    private IssueTimeType issueTimeField;

    private NominationDateType nominationDateField;

    private PeriodType nominationPeriodField;

    private NominationTimeType nominationTimeField;

    private NoteType[] noteField;

    private PeriodType validityPeriodField;

    private VersionIDType versionIDField;

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
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationDateType NominationDate
    {
        get => nominationDateField;
        set => nominationDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NominationTimeType NominationTime
    {
        get => nominationTimeField;
        set => nominationTimeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractTypeCodeType ContractTypeCode
    {
        get => contractTypeCodeField;
        set => contractTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractTypeType ContractType1
    {
        get => contractType1Field;
        set => contractType1Field = value;
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
    public VersionIDType VersionID
    {
        get => versionIDField;
        set => versionIDField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public PeriodType ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    [XmlElement("ContractDocumentReference")]
    public DocumentReferenceType[] ContractDocumentReference
    {
        get => contractDocumentReferenceField;
        set => contractDocumentReferenceField = value;
    }

    /// <remarks />
    public PeriodType NominationPeriod
    {
        get => nominationPeriodField;
        set => nominationPeriodField = value;
    }

    /// <remarks />
    public DeliveryType ContractualDelivery
    {
        get => contractualDeliveryField;
        set => contractualDeliveryField = value;
    }
}