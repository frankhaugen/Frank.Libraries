namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class IncludeType
    {

        private string _uRiField;

        private bool _referencedDataField;

        private bool _referencedDataFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Uri
        {
            get
            {
                return _uRiField;
            }
            set
            {
                _uRiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReferencedData
        {
            get
            {
                return _referencedDataField;
            }
            set
            {
                _referencedDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReferencedDataSpecified
        {
            get
            {
                return _referencedDataFieldSpecified;
            }
            set
            {
                _referencedDataFieldSpecified = value;
            }
        }
    }
}