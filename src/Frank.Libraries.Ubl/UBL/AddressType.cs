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
[XmlRoot("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class AddressType
{
    private AdditionalStreetNameType additionalStreetNameField;

    private AddressFormatCodeType addressFormatCodeField;

    private AddressLineType[] addressLineField;

    private AddressTypeCodeType addressTypeCodeField;

    private BlockNameType blockNameField;

    private BuildingNameType buildingNameField;

    private BuildingNumberType buildingNumberField;

    private CityNameType cityNameField;

    private CitySubdivisionNameType citySubdivisionNameField;

    private CountryType countryField;

    private CountrySubentityCodeType countrySubentityCodeField;

    private CountrySubentityType countrySubentityField;

    private DepartmentType departmentField;

    private DistrictType districtField;

    private FloorType floorField;

    private IDType idField;

    private InhouseMailType inhouseMailField;

    private LocationCoordinateType[] locationCoordinateField;

    private MarkAttentionType markAttentionField;

    private MarkCareType markCareField;

    private PlotIdentificationType plotIdentificationField;

    private PostalZoneType postalZoneField;

    private PostboxType postboxField;

    private RegionType regionField;

    private RoomType roomField;

    private StreetNameType streetNameField;

    private TimezoneOffsetType timezoneOffsetField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AddressTypeCodeType AddressTypeCode
    {
        get => addressTypeCodeField;
        set => addressTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AddressFormatCodeType AddressFormatCode
    {
        get => addressFormatCodeField;
        set => addressFormatCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PostboxType Postbox
    {
        get => postboxField;
        set => postboxField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FloorType Floor
    {
        get => floorField;
        set => floorField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RoomType Room
    {
        get => roomField;
        set => roomField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StreetNameType StreetName
    {
        get => streetNameField;
        set => streetNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalStreetNameType AdditionalStreetName
    {
        get => additionalStreetNameField;
        set => additionalStreetNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BlockNameType BlockName
    {
        get => blockNameField;
        set => blockNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BuildingNameType BuildingName
    {
        get => buildingNameField;
        set => buildingNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BuildingNumberType BuildingNumber
    {
        get => buildingNumberField;
        set => buildingNumberField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InhouseMailType InhouseMail
    {
        get => inhouseMailField;
        set => inhouseMailField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DepartmentType Department
    {
        get => departmentField;
        set => departmentField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkAttentionType MarkAttention
    {
        get => markAttentionField;
        set => markAttentionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MarkCareType MarkCare
    {
        get => markCareField;
        set => markCareField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PlotIdentificationType PlotIdentification
    {
        get => plotIdentificationField;
        set => plotIdentificationField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CitySubdivisionNameType CitySubdivisionName
    {
        get => citySubdivisionNameField;
        set => citySubdivisionNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CityNameType CityName
    {
        get => cityNameField;
        set => cityNameField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PostalZoneType PostalZone
    {
        get => postalZoneField;
        set => postalZoneField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityType CountrySubentity
    {
        get => countrySubentityField;
        set => countrySubentityField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityCodeType CountrySubentityCode
    {
        get => countrySubentityCodeField;
        set => countrySubentityCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RegionType Region
    {
        get => regionField;
        set => regionField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DistrictType District
    {
        get => districtField;
        set => districtField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TimezoneOffsetType TimezoneOffset
    {
        get => timezoneOffsetField;
        set => timezoneOffsetField = value;
    }

    /// <remarks />
    [XmlElement("AddressLine")]
    public AddressLineType[] AddressLine
    {
        get => addressLineField;
        set => addressLineField = value;
    }

    /// <remarks />
    public CountryType Country
    {
        get => countryField;
        set => countryField = value;
    }

    /// <remarks />
    [XmlElement("LocationCoordinate")]
    public LocationCoordinateType[] LocationCoordinate
    {
        get => locationCoordinateField;
        set => locationCoordinateField = value;
    }
}