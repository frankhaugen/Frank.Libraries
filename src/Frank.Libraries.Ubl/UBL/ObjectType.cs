using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ObjectType
{
    private XmlNode[] anyField;

    private string encodingField;

    private string idField;

    private string mimeTypeField;

    /// <remarks />
    [XmlText]
    [XmlAnyElement]
    public XmlNode[] Any
    {
        get => anyField;
        set => anyField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string MimeType
    {
        get => mimeTypeField;
        set => mimeTypeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string Encoding
    {
        get => encodingField;
        set => encodingField = value;
    }
}