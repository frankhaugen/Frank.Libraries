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
[XmlRoot("BusinessClassificationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class ClassificationSchemeType
{
    private AgencyIDType agencyIDField;

    private AgencyNameType agencyNameField;

    private ClassificationCategoryType[] classificationCategoryField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private LanguageIDType languageIDField;

    private LastRevisionDateType lastRevisionDateField;

    private LastRevisionTimeType lastRevisionTimeField;

    private NameType1 nameField;

    private NoteType[] noteField;

    private SchemeURIType schemeURIField;

    private URIType uRIField;

    private UUIDType uUIDField;

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
    public UUIDType UUID
    {
        get => uUIDField;
        set => uUIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LastRevisionDateType LastRevisionDate
    {
        get => lastRevisionDateField;
        set => lastRevisionDateField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LastRevisionTimeType LastRevisionTime
    {
        get => lastRevisionTimeField;
        set => lastRevisionTimeField = value;
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
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AgencyIDType AgencyID
    {
        get => agencyIDField;
        set => agencyIDField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AgencyNameType AgencyName
    {
        get => agencyNameField;
        set => agencyNameField = value;
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
    public URIType URI
    {
        get => uRIField;
        set => uRIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SchemeURIType SchemeURI
    {
        get => schemeURIField;
        set => schemeURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LanguageIDType LanguageID
    {
        get => languageIDField;
        set => languageIDField = value;
    }

    /// <remarks />
    [XmlElement("ClassificationCategory")]
    public ClassificationCategoryType[] ClassificationCategory
    {
        get => classificationCategoryField;
        set => classificationCategoryField = value;
    }
}