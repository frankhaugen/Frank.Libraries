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
[XmlRoot("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public class KeyInfoType
{
    private string idField;

    private ItemsChoiceType2[] itemsElementNameField;

    private object[] itemsField;

    private string[] textField;

    /// <remarks />
    [XmlAnyElement]
    [XmlElement("KeyName", typeof(string))]
    [XmlElement("KeyValue", typeof(KeyValueType))]
    [XmlElement("MgmtData", typeof(string))]
    [XmlElement("PGPData", typeof(PGPDataType))]
    [XmlElement("RetrievalMethod", typeof(RetrievalMethodType))]
    [XmlElement("SPKIData", typeof(SPKIDataType))]
    [XmlElement("X509Data", typeof(X509DataType))]
    [XmlChoiceIdentifier("ItemsElementName")]
    public object[] Items
    {
        get => itemsField;
        set => itemsField = value;
    }

    /// <remarks />
    [XmlElement("ItemsElementName")]
    [XmlIgnore]
    public ItemsChoiceType2[] ItemsElementName
    {
        get => itemsElementNameField;
        set => itemsElementNameField = value;
    }

    /// <remarks />
    [XmlText]
    public string[] Text
    {
        get => textField;
        set => textField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}