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
[XmlRoot("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class IncludeType
{
    private bool referencedDataField;

    private bool referencedDataFieldSpecified;

    private string uRIField;

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public bool referencedData
    {
        get => referencedDataField;
        set => referencedDataField = value;
    }

    /// <remarks />
    [XmlIgnore]
    public bool referencedDataSpecified
    {
        get => referencedDataFieldSpecified;
        set => referencedDataFieldSpecified = value;
    }
}