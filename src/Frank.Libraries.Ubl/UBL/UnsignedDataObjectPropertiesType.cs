using System;
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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("UnsignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class UnsignedDataObjectPropertiesType
{
    private string idField;

    private AnyType[] unsignedDataObjectPropertyField;

    /// <remarks />
    [XmlElement("UnsignedDataObjectProperty")]
    public AnyType[] UnsignedDataObjectProperty
    {
        get => unsignedDataObjectPropertyField;
        set => unsignedDataObjectPropertyField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}