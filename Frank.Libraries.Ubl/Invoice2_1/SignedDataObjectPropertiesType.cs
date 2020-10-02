namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignedDataObjectPropertiesType
    {

        private DataObjectFormatType[] dataObjectFormatField;

        private CommitmentTypeIndicationType[] commitmentTypeIndicationField;

        private XAdESTimeStampType[] allDataObjectsTimeStampField;

        private XAdESTimeStampType[] individualDataObjectsTimeStampField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
        public DataObjectFormatType[] DataObjectFormat
        {
            get
            {
                return dataObjectFormatField;
            }
            set
            {
                dataObjectFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
        public CommitmentTypeIndicationType[] CommitmentTypeIndication
        {
            get
            {
                return commitmentTypeIndicationField;
            }
            set
            {
                commitmentTypeIndicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
        public XAdESTimeStampType[] AllDataObjectsTimeStamp
        {
            get
            {
                return allDataObjectsTimeStampField;
            }
            set
            {
                allDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
        public XAdESTimeStampType[] IndividualDataObjectsTimeStamp
        {
            get
            {
                return individualDataObjectsTimeStampField;
            }
            set
            {
                individualDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }
}