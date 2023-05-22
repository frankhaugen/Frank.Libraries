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
[XmlRoot("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class DSAKeyValueType
{
    private byte[] gField;

    private byte[] jField;

    private byte[] pField;

    private byte[] pgenCounterField;

    private byte[] qField;

    private byte[] seedField;

    private byte[] yField;

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] P
    {
        get => pField;
        set => pField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] Q
    {
        get => qField;
        set => qField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] G
    {
        get => gField;
        set => gField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] Y
    {
        get => yField;
        set => yField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] J
    {
        get => jField;
        set => jField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] Seed
    {
        get => seedField;
        set => seedField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] PgenCounter
    {
        get => pgenCounterField;
        set => pgenCounterField = value;
    }
}