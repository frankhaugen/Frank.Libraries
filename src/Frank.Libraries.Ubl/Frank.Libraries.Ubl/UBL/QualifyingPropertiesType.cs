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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class QualifyingPropertiesType
{
    private string idField;

    private SignedPropertiesType signedPropertiesField;

    private string targetField;

    private UnsignedPropertiesType unsignedPropertiesField;

    /// <remarks />
    public SignedPropertiesType SignedProperties
    {
        get => signedPropertiesField;
        set => signedPropertiesField = value;
    }

    /// <remarks />
    public UnsignedPropertiesType UnsignedProperties
    {
        get => unsignedPropertiesField;
        set => unsignedPropertiesField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string Target
    {
        get => targetField;
        set => targetField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}