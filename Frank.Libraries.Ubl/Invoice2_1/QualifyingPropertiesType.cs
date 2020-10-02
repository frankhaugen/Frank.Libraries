namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class QualifyingPropertiesType
    {

        private SignedPropertiesType _signedPropertiesField;

        private UnsignedPropertiesType _unsignedPropertiesField;

        private string _targetField;

        private string _idField;

        /// <remarks/>
        public SignedPropertiesType SignedProperties
        {
            get
            {
                return _signedPropertiesField;
            }
            set
            {
                _signedPropertiesField = value;
            }
        }

        /// <remarks/>
        public UnsignedPropertiesType UnsignedProperties
        {
            get
            {
                return _unsignedPropertiesField;
            }
            set
            {
                _unsignedPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Target
        {
            get
            {
                return _targetField;
            }
            set
            {
                _targetField = value;
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