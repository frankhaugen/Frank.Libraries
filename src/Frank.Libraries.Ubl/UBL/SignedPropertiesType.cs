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
[XmlRoot("SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignedPropertiesType
{
    private string idField;

    private SignedDataObjectPropertiesType signedDataObjectPropertiesField;

    private SignedSignaturePropertiesType signedSignaturePropertiesField;

    /// <remarks />
    public SignedSignaturePropertiesType SignedSignatureProperties
    {
        get => signedSignaturePropertiesField;
        set => signedSignaturePropertiesField = value;
    }

    /// <remarks />
    public SignedDataObjectPropertiesType SignedDataObjectProperties
    {
        get => signedDataObjectPropertiesField;
        set => signedDataObjectPropertiesField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}