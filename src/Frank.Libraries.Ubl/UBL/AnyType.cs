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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("Any", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class AnyType
{
    private XmlAttribute[] anyAttrField;

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
    [XmlAnyAttribute]
    public XmlAttribute[] AnyAttr
    {
        get => anyAttrField;
        set => anyAttrField = value;
    }
}