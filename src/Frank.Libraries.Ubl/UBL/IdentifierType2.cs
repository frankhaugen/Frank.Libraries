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
[XmlType(TypeName = "IdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public class IdentifierType2
{
    private QualifierType qualifierField;

    private bool qualifierFieldSpecified;

    private string valueField;

    /// <remarks />
    [XmlAttribute]
    public QualifierType Qualifier
    {
        get => qualifierField;
        set => qualifierField = value;
    }

    /// <remarks />
    [XmlIgnore]
    public bool QualifierSpecified
    {
        get => qualifierFieldSpecified;
        set => qualifierFieldSpecified = value;
    }

    /// <remarks />
    [XmlText(DataType = "anyURI")]
    public string Value
    {
        get => valueField;
        set => valueField = value;
    }
}