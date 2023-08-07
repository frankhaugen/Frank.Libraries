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
[XmlRoot("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public class SignedDataObjectPropertiesType
{
    private XAdESTimeStampType[] allDataObjectsTimeStampField;

    private CommitmentTypeIndicationType[] commitmentTypeIndicationField;

    private DataObjectFormatType[] dataObjectFormatField;

    private string idField;

    private XAdESTimeStampType[] individualDataObjectsTimeStampField;

    /// <remarks />
    [XmlElement("DataObjectFormat")]
    public DataObjectFormatType[] DataObjectFormat
    {
        get => dataObjectFormatField;
        set => dataObjectFormatField = value;
    }

    /// <remarks />
    [XmlElement("CommitmentTypeIndication")]
    public CommitmentTypeIndicationType[] CommitmentTypeIndication
    {
        get => commitmentTypeIndicationField;
        set => commitmentTypeIndicationField = value;
    }

    /// <remarks />
    [XmlElement("AllDataObjectsTimeStamp")]
    public XAdESTimeStampType[] AllDataObjectsTimeStamp
    {
        get => allDataObjectsTimeStampField;
        set => allDataObjectsTimeStampField = value;
    }

    /// <remarks />
    [XmlElement("IndividualDataObjectsTimeStamp")]
    public XAdESTimeStampType[] IndividualDataObjectsTimeStamp
    {
        get => individualDataObjectsTimeStampField;
        set => individualDataObjectsTimeStampField = value;
    }

    /// <remarks />
    [XmlAttribute(DataType = "ID")]
    public string Id
    {
        get => idField;
        set => idField = value;
    }
}