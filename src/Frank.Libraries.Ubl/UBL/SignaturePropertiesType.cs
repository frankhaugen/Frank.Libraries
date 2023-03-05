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
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class SignaturePropertiesType
{
    private string idField;

    private SignaturePropertyType[] signaturePropertyField;

    /// <remarks />
    [XmlElement("SignatureProperty")]
    public SignaturePropertyType[] SignatureProperty
    {
        get => signaturePropertyField;
        set => signaturePropertyField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}