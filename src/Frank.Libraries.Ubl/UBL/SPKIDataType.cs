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
[XmlRoot("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SPKIDataType
{
    private XmlElement anyField;

    private byte[][] sPKISexpField;

    /// <remarks />
    [XmlElement("SPKISexp", DataType = "base64Binary")]
    public byte[][] SPKISexp
    {
        get => sPKISexpField;
        set => sPKISexpField = value;
    }

    /// <remarks />
    [XmlAnyElement]
    public XmlElement Any
    {
        get => anyField;
        set => anyField = value;
    }
}