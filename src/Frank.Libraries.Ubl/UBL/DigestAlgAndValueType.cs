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
public class DigestAlgAndValueType
{
    private DigestMethodType digestMethodField;

    private byte[] digestValueField;

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public DigestMethodType DigestMethod
    {
        get => digestMethodField;
        set => digestMethodField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType = "base64Binary")]
    public byte[] DigestValue
    {
        get => digestValueField;
        set => digestValueField = value;
    }
}