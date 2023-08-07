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
[XmlRoot("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class KeyValueType
{
    private object itemField;

    private string[] textField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
    [XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
    public object Item
    {
        get => itemField;
        set => itemField = value;
    }

    /// <remarks />
    [XmlText]
    public string[] Text
    {
        get => textField;
        set => textField = value;
    }
}