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
[XmlRoot("ReferenceInfo", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class ReferenceInfoType
{
    private DigestMethodType digestMethodField;

    private byte[] digestValueField;

    private string idField;

    private string uRIField;

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public DigestMethodType DigestMethod
    {
        get => digestMethodField;
        set => digestMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType = "base64Binary")]
    public byte[] DigestValue
    {
        get => digestValueField;
        set => digestValueField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }
}