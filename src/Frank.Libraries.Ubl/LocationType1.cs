namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class LocationType1
{

    private IDType idField;

    private DescriptionType[] descriptionField;

    private ConditionsType[] conditionsField;

    private CountrySubentityType countrySubentityField;

    private CountrySubentityCodeType countrySubentityCodeField;

    private LocationTypeCodeType locationTypeCodeField;

    private InformationURIType informationURIField;

    private NameType1 nameField;

    private PeriodType[] validityPeriodField;

    private AddressType addressField;

    private LocationType1[] subsidiaryLocationField;

    private LocationCoordinateType[] locationCoordinateField;

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
    [System.Xml.Serialization.XmlElementAttribute("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionsType[] Conditions
    {
        get
        {
            return this.conditionsField;
        }
        set
        {
            this.conditionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityType CountrySubentity
    {
        get
        {
            return this.countrySubentityField;
        }
        set
        {
            this.countrySubentityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityCodeType CountrySubentityCode
    {
        get
        {
            return this.countrySubentityCodeField;
        }
        set
        {
            this.countrySubentityCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LocationTypeCodeType LocationTypeCode
    {
        get
        {
            return this.locationTypeCodeField;
        }
        set
        {
            this.locationTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationURIType InformationURI
    {
        get
        {
            return this.informationURIField;
        }
        set
        {
            this.informationURIField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
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
    public AddressType Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation")]
    public LocationType1[] SubsidiaryLocation
    {
        get
        {
            return this.subsidiaryLocationField;
        }
        set
        {
            this.subsidiaryLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate")]
    public LocationCoordinateType[] LocationCoordinate
    {
        get
        {
            return this.locationCoordinateField;
        }
        set
        {
            this.locationCoordinateField = value;
        }
    }
}