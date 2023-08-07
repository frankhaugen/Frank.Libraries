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
[XmlRoot("DataObjectFormat", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class DataObjectFormatType
{
    private string descriptionField;

    private string encodingField;

    private string mimeTypeField;

    private ObjectIdentifierType objectIdentifierField;

    private string objectReferenceField;

    /// <remarks />
    public string Description
    {
        get => descriptionField;
        set => descriptionField = value;
    }

    /// <remarks />
    public ObjectIdentifierType ObjectIdentifier
    {
        get => objectIdentifierField;
        set => objectIdentifierField = value;
    }

    /// <remarks />
    public string MimeType
    {
        get => mimeTypeField;
        set => mimeTypeField = value;
    }

    /// <remarks />
    [XmlElement(DataType = "anyURI")]
    public string Encoding
    {
        get => encodingField;
        set => encodingField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string ObjectReference
    {
        get => objectReferenceField;
        set => objectReferenceField = value;
    }
}