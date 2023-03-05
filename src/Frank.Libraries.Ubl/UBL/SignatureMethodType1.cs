using System;
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
[XmlType(TypeName = "SignatureMethodType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignatureMethodType1
{
    private string algorithmField;

    private XmlNode[] anyField;

    private string hMACOutputLengthField;

    /// <remarks />
    [XmlElement(DataType = "integer")]
    public string HMACOutputLength
    {
        get => hMACOutputLengthField;
        set => hMACOutputLengthField = value;
    }

    /// <remarks />
    [XmlText]
    [XmlAnyElement]
    public XmlNode[] Any
    {
        get => anyField;
        set => anyField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get => algorithmField;
        set => algorithmField = value;
    }
}