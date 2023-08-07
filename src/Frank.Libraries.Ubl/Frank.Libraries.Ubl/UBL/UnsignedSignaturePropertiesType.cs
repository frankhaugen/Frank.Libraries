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
[XmlRoot("UnsignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class UnsignedSignaturePropertiesType
{
    private string idField;

    private ItemsChoiceType3[] itemsElementNameField;

    private object[] itemsField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("ArchiveTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("AttrAuthoritiesCertValues", typeof(CertificateValuesType))]
    [XmlElement("AttributeCertificateRefs", typeof(CompleteCertificateRefsType))]
    [XmlElement("AttributeRevocationRefs", typeof(CompleteRevocationRefsType))]
    [XmlElement("AttributeRevocationValues", typeof(RevocationValuesType))]
    [XmlElement("CertificateValues", typeof(CertificateValuesType))]
    [XmlElement("CompleteCertificateRefs", typeof(CompleteCertificateRefsType))]
    [XmlElement("CompleteRevocationRefs", typeof(CompleteRevocationRefsType))]
    [XmlElement("CounterSignature", typeof(CounterSignatureType))]
    [XmlElement("RefsOnlyTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("RevocationValues", typeof(RevocationValuesType))]
    [XmlElement("SigAndRefsTimeStamp", typeof(XAdESTimeStampType))]
    [XmlElement("SignatureTimeStamp", typeof(XAdESTimeStampType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType3[] ItemsElementName
    {
        get => itemsElementNameField;
        set => itemsElementNameField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}