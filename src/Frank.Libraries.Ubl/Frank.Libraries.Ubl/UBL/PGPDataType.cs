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
[XmlRoot("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class PGPDataType
{
    private ItemsChoiceType1[] itemsElementNameField;

    private object[] itemsField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("PGPKeyID", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("PGPKeyPacket", typeof(byte[]), DataType = "base64Binary")]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType1[] ItemsElementName
    {
        get => itemsElementNameField;
        set => itemsElementNameField = value;
    }
}