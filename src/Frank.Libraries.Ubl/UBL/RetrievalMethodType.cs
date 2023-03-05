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
[XmlRoot("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class RetrievalMethodType
{
    private TransformType[] transformsField;

    private string typeField;

    private string uRIField;

    /// <remarks />
    [XmlArrayItem("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get => transformsField;
        set => transformsField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string Type
    {
        get => typeField;
        set => typeField = value;
    }
}