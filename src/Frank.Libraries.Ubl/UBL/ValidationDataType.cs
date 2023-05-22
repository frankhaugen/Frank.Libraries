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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.4.1#")]
[XmlRoot("TimeStampValidationData", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable = false)]
public class ValidationDataType
{
    private CertificateValuesType certificateValuesField;

    private string idField;

    private RevocationValuesType revocationValuesField;

    private string urField;

    /// <remarks />
    [XmlElement(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public CertificateValuesType CertificateValues
    {
        get => certificateValuesField;
        set => certificateValuesField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public RevocationValuesType RevocationValues
    {
        get => revocationValuesField;
        set => revocationValuesField = value;
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
    public string UR
    {
        get => urField;
        set => urField = value;
    }
}