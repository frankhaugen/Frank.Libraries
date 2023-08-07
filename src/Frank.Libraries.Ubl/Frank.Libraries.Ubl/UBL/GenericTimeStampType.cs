using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Ubl.UBL;

/// <remarks />
[XmlInclude(typeof(OtherTimeStampType))]
[XmlInclude(typeof(XAdESTimeStampType))]
[GeneratedCode("xsd", "4.8.3928.0")]
[Serializable]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public abstract class GenericTimeStampType
{
    private CanonicalizationMethodType1 canonicalizationMethodField;

    private string idField;

    private object[] items1Field;

    private object[] itemsField;

    /// <remarks />
    [XmlElement("Include", typeof(IncludeType))]
    [XmlElement("ReferenceInfo", typeof(ReferenceInfoType))]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public CanonicalizationMethodType1 CanonicalizationMethod
    {
        get => canonicalizationMethodField;
        set => canonicalizationMethodField = value;
    }

    /// <remarks />
    [XmlElement("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
    [XmlElement("XMLTimeStamp", typeof(AnyType))]
    public object[] Items1
    {
        get => items1Field;
        set => items1Field = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}