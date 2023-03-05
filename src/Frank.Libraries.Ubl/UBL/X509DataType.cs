using System;
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
[XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class X509DataType
{
    private ItemsChoiceType[] itemsElementNameField;

    private object[] itemsField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
    [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
    [XmlElement("X509SubjectName", typeof(string))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType[] ItemsElementName
    {
        get => itemsElementNameField;
        set => itemsElementNameField = value;
    }
}