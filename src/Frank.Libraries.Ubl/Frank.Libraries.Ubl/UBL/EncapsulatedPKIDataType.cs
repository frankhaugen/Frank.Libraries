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
[XmlRoot("EncapsulatedPKIData", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class EncapsulatedPKIDataType
{
    private string encodingField;

    private string idField;

    private byte[] valueField;

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string Encoding
    {
        get => encodingField;
        set => encodingField = value;
    }

    /// <remarks />
    [XmlText(DataType = "base64Binary")]
    public byte[] Value
    {
        get => valueField;
        set => valueField = value;
    }
}