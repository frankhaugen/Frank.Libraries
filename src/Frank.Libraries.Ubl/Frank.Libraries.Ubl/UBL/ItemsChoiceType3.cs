using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IncludeInSchema = false)]
public enum ItemsChoiceType3
{
    /// <remarks />
    [XmlEnum("##any:")] Item,

    /// <remarks />
    ArchiveTimeStamp,

    /// <remarks />
    AttrAuthoritiesCertValues,

    /// <remarks />
    AttributeCertificateRefs,

    /// <remarks />
    AttributeRevocationRefs,

    /// <remarks />
    AttributeRevocationValues,

    /// <remarks />
    CertificateValues,

    /// <remarks />
    CompleteCertificateRefs,

    /// <remarks />
    CompleteRevocationRefs,

    /// <remarks />
    CounterSignature,

    /// <remarks />
    RefsOnlyTimeStamp,

    /// <remarks />
    RevocationValues,

    /// <remarks />
    SigAndRefsTimeStamp,

    /// <remarks />
    SignatureTimeStamp
}