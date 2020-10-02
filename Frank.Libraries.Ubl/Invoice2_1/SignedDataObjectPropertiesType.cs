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

        private DataObjectFormatType[] _dataObjectFormatField;

        private CommitmentTypeIndicationType[] _commitmentTypeIndicationField;

        private XAdEsTimeStampType[] _allDataObjectsTimeStampField;

        private XAdEsTimeStampType[] _individualDataObjectsTimeStampField;

        private string _idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
        public DataObjectFormatType[] DataObjectFormat
        {
            get
            {
                return _dataObjectFormatField;
            }
            set
            {
                _dataObjectFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
        public CommitmentTypeIndicationType[] CommitmentTypeIndication
        {
            get
            {
                return _commitmentTypeIndicationField;
            }
            set
            {
                _commitmentTypeIndicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
        public XAdEsTimeStampType[] AllDataObjectsTimeStamp
        {
            get
            {
                return _allDataObjectsTimeStampField;
            }
            set
            {
                _allDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
        public XAdEsTimeStampType[] IndividualDataObjectsTimeStamp
        {
            get
            {
                return _individualDataObjectsTimeStampField;
            }
            set
            {
                _individualDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }
    }
}