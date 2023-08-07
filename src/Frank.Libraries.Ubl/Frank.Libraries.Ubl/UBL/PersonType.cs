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
[XmlRoot("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class PersonType
{
    private BirthDateType birthDateField;

    private BirthplaceNameType birthplaceNameField;

    private ContactType contactField;

    private FamilyNameType familyNameField;

    private FinancialAccountType financialAccountField;

    private FirstNameType firstNameField;

    private GenderCodeType genderCodeField;

    private DocumentReferenceType[] identityDocumentReferenceField;

    private IDType idField;

    private JobTitleType jobTitleField;

    private MiddleNameType middleNameField;

    private NameSuffixType nameSuffixField;

    private NationalityIDType nationalityIDField;

    private OrganizationDepartmentType organizationDepartmentField;

    private OtherNameType otherNameField;

    private AddressType residenceAddressField;

    private TitleType titleField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FirstNameType FirstName
    {
        get => firstNameField;
        set => firstNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FamilyNameType FamilyName
    {
        get => familyNameField;
        set => familyNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TitleType Title
    {
        get => titleField;
        set => titleField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MiddleNameType MiddleName
    {
        get => middleNameField;
        set => middleNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OtherNameType OtherName
    {
        get => otherNameField;
        set => otherNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameSuffixType NameSuffix
    {
        get => nameSuffixField;
        set => nameSuffixField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JobTitleType JobTitle
    {
        get => jobTitleField;
        set => jobTitleField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NationalityIDType NationalityID
    {
        get => nationalityIDField;
        set => nationalityIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GenderCodeType GenderCode
    {
        get => genderCodeField;
        set => genderCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BirthDateType BirthDate
    {
        get => birthDateField;
        set => birthDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BirthplaceNameType BirthplaceName
    {
        get => birthplaceNameField;
        set => birthplaceNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrganizationDepartmentType OrganizationDepartment
    {
        get => organizationDepartmentField;
        set => organizationDepartmentField = value;
    }

    /// <remarks />
    public ContactType Contact
    {
        get => contactField;
        set => contactField = value;
    }

    /// <remarks />
    public FinancialAccountType FinancialAccount
    {
        get => financialAccountField;
        set => financialAccountField = value;
    }

    /// <remarks />
    [XmlElement("IdentityDocumentReference")]
    public DocumentReferenceType[] IdentityDocumentReference
    {
        get => identityDocumentReferenceField;
        set => identityDocumentReferenceField = value;
    }

    /// <remarks />
    public AddressType ResidenceAddress
    {
        get => residenceAddressField;
        set => residenceAddressField = value;
    }
}