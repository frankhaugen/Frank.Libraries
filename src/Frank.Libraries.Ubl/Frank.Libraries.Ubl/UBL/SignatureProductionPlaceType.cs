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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignatureProductionPlaceType
{
    private string cityField;

    private string countryNameField;

    private string postalCodeField;

    private string stateOrProvinceField;

    /// <remarks />
    public string City
    {
        get => cityField;
        set => cityField = value;
    }

    /// <remarks />
    public string StateOrProvince
    {
        get => stateOrProvinceField;
        set => stateOrProvinceField = value;
    }

    /// <remarks />
    public string PostalCode
    {
        get => postalCodeField;
        set => postalCodeField = value;
    }

    /// <remarks />
    public string CountryName
    {
        get => countryNameField;
        set => countryNameField = value;
    }
}