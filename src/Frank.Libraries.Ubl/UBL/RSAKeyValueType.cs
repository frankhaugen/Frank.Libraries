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
[XmlRoot("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class RSAKeyValueType
{
    private byte[] exponentField;

    private byte[] modulusField;

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] Modulus
    {
        get => modulusField;
        set => modulusField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] Exponent
    {
        get => exponentField;
        set => exponentField = value;
    }
}