using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public enum QualifierType
{
    /// <remarks />
    OIDAsURI,

    /// <remarks />
    OIDAsURN
}