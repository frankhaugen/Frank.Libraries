namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class SignatureProductionPlaceType
{

    private string cityField;

    private string stateOrProvinceField;

    private string postalCodeField;

    private string countryNameField;

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string StateOrProvince
    {
        get
        {
            return this.stateOrProvinceField;
        }
        set
        {
            this.stateOrProvinceField = value;
        }
    }

    /// <remarks/>
    public string PostalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <remarks/>
    public string CountryName
    {
        get
        {
            return this.countryNameField;
        }
        set
        {
            this.countryNameField = value;
        }
    }
}