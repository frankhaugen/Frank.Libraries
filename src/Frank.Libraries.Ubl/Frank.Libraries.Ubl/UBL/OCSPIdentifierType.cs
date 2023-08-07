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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public class OCSPIdentifierType
{
    private DateTime producedAtField;

    private ResponderIDType responderIDField;

    private string uRIField;

    /// <remarks />
    public ResponderIDType ResponderID
    {
        get => responderIDField;
        set => responderIDField = value;
    }

    /// <remarks />
    public DateTime ProducedAt
    {
        get => producedAtField;
        set => producedAtField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "anyURI")]
    public string URI
    {
        get => uRIField;
        set => uRIField = value;
    }
}