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
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class TransformType
{
    private string algorithmField;

    private object[] itemsField;

    private string[] textField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("XPath", typeof(string))]
    public object[] Items
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
    public string Algorithm
    {
        get => algorithmField;
        set => algorithmField = value;
    }
}