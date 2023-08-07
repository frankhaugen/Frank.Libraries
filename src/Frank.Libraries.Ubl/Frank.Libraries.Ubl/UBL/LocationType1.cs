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
[XmlType(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[XmlRoot("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public class LocationType1
{
    private AddressType addressField;

    private ConditionsType[] conditionsField;

    private CountrySubentityCodeType countrySubentityCodeField;

    private CountrySubentityType countrySubentityField;

    private DescriptionType[] descriptionField;

    private IDType idField;

    private InformationURIType informationURIField;

    private LocationCoordinateType[] locationCoordinateField;

    private LocationTypeCodeType locationTypeCodeField;

    private NameType1 nameField;

    private LocationType1[] subsidiaryLocationField;

    private PeriodType[] validityPeriodField;

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlElement("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    [XmlElement("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionsType[] Conditions
    {
        get => conditionsField;
        set => conditionsField = value;
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
    public LocationTypeCodeType LocationTypeCode
    {
        get => locationTypeCodeField;
        set => locationTypeCodeField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationURIType InformationURI
    {
        get => informationURIField;
        set => informationURIField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name
    {
        get => nameField;
        set => nameField = value;
    }

    /// <remarks />
    [XmlElement("ValidityPeriod")]
    public PeriodType[] ValidityPeriod
    {
        get => validityPeriodField;
        set => validityPeriodField = value;
    }

    /// <remarks />
    public AddressType Address
    {
        get => addressField;
        set => addressField = value;
    }

    /// <remarks />
    [XmlElement("SubsidiaryLocation")]
    public LocationType1[] SubsidiaryLocation
    {
        get => subsidiaryLocationField;
        set => subsidiaryLocationField = value;
    }

    /// <remarks />
    [XmlElement("LocationCoordinate")]
    public LocationCoordinateType[] LocationCoordinate
    {
        get => locationCoordinateField;
        set => locationCoordinateField = value;
    }
}