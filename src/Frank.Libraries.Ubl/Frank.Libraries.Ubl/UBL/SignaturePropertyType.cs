using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignaturePropertyType
{
    private string idField;

    private XmlElement[] itemsField;

    private string targetField;

    private string[] textField;

    /// <remarks />
    [XmlAnyElement]
    public XmlElement[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlText]
    public string[] Text
    {
        get => textField;
        set => textField = value;
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