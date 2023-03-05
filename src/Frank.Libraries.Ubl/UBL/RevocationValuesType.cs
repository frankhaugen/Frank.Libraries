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
[XmlType(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[XmlRoot("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class RevocationValuesType
{
    private EncapsulatedPKIDataType[] cRLValuesField;

    private string idField;

    private EncapsulatedPKIDataType[] oCSPValuesField;

    private AnyType[] otherValuesField;

    /// <remarks />
    [XmlArrayItem("EncapsulatedCRLValue", IsNullable = false)]
    public EncapsulatedPKIDataType[] CRLValues
    {
        get => cRLValuesField;
        set => cRLValuesField = value;
    }

    /// <remarks />
    [XmlArrayItem("EncapsulatedOCSPValue", IsNullable = false)]
    public EncapsulatedPKIDataType[] OCSPValues
    {
        get => oCSPValuesField;
        set => oCSPValuesField = value;
    }

    /// <remarks />
    [XmlArrayItem("OtherValue", IsNullable = false)]
    public AnyType[] OtherValues
    {
        get => otherValuesField;
        set => otherValuesField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}