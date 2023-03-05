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
[XmlType(TypeName = "CanonicalizationMethodType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class CanonicalizationMethodType1
{
    private string algorithmField;

    private XmlNode[] anyField;

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