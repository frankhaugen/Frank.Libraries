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
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class ManifestType
{
    private string idField;

    private ReferenceType1[] referenceField;

    /// <remarks />
    [XmlElement("Reference")]
    public ReferenceType1[] Reference
    {
        get => referenceField;
        set => referenceField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}