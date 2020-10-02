namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class UnsignedPropertiesType
    {

        private UnsignedSignaturePropertiesType _unsignedSignaturePropertiesField;

        private UnsignedDataObjectPropertiesType _unsignedDataObjectPropertiesField;

        private string _idField;

        /// <remarks/>
        public UnsignedSignaturePropertiesType UnsignedSignatureProperties
        {
            get
            {
                return _unsignedSignaturePropertiesField;
            }
            set
            {
                _unsignedSignaturePropertiesField = value;
            }
        }

        /// <remarks/>
        public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties
        {
            get
            {
                return _unsignedDataObjectPropertiesField;
            }
            set
            {
                _unsignedDataObjectPropertiesField = value;
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