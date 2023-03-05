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
[XmlRoot("UnsignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class UnsignedPropertiesType
{
    private string idField;

    private UnsignedDataObjectPropertiesType unsignedDataObjectPropertiesField;

    private UnsignedSignaturePropertiesType unsignedSignaturePropertiesField;

    /// <remarks />
    public UnsignedSignaturePropertiesType UnsignedSignatureProperties
    {
        get => unsignedSignaturePropertiesField;
        set => unsignedSignaturePropertiesField = value;
    }

    /// <remarks />
    public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties
    {
        get => unsignedDataObjectPropertiesField;
        set => unsignedDataObjectPropertiesField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}