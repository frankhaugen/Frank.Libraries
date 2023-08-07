using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(TypeName = "ReferenceType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ReferenceType1
{
    private DigestMethodType digestMethodField;

    private byte[] digestValueField;

    private string idField;

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
    public DigestMethodType DigestMethod
    {
        get => digestMethodField;
        set => digestMethodField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "base64Binary")]
    public byte[] DigestValue
    {
        get => digestValueField;
        set => digestValueField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
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