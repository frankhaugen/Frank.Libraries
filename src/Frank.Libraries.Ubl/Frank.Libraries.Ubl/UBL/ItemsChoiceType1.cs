using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType1
{
    /// <remarks />
    [XmlEnum("##any:")] Item,

    /// <remarks />
    PGPKeyID,

    /// <remarks />
    PGPKeyPacket
}