using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[XmlInclude(typeof(VideoType))]
[XmlInclude(typeof(SoundType))]
[XmlInclude(typeof(PictureType))]
[XmlInclude(typeof(GraphicType))]
[XmlInclude(typeof(BinaryObjectType1))]
[XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
public class BinaryObjectType
{
    private string characterSetCodeField;

    private string encodingCodeField;

    private string filenameField;

    private string formatField;

    private string mimeCodeField;

    private string uriField;

    private byte[] valueField;

    /// <remarks />
    [XmlAttribute]
    public string format
    {
        get => formatField;
        set => formatField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string mimeCode
    {
        get => mimeCodeField;
        set => mimeCodeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string encodingCode
    {
        get => encodingCodeField;
        set => encodingCodeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "normalizedString")]
    public string characterSetCode
    {
        get => characterSetCodeField;
        set => characterSetCodeField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string uri
    {
        get => uriField;
        set => uriField = value;
    }

    /// <remarks />
    [XmlAttribute]
    public string filename
    {
        get => filenameField;
        set => filenameField = value;
    }

    /// <remarks />
    [XmlText(DataType = "base64Binary")]
    public byte[] Value
    {
        get => valueField;
        set => valueField = value;
    }
}