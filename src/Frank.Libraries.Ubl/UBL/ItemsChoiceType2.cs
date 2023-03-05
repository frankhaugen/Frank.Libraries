using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType2
{
    /// <remarks />
    [XmlEnum("##any:")] Item,

    /// <remarks />
    KeyName,

    /// <remarks />
    KeyValue,

    /// <remarks />
    MgmtData,

    /// <remarks />
    PGPData,

    /// <remarks />
    RetrievalMethod,

    /// <remarks />
    SPKIData,

    /// <remarks />
    X509Data
}