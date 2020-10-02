namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("DataObjectFormat", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class DataObjectFormatType
    {

        private string _descriptionField;

        private ObjectIdentifierType _objectIdentifierField;

        private string _mimeTypeField;

        private string _encodingField;

        private string _objectReferenceField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        public ObjectIdentifierType ObjectIdentifier
        {
            get
            {
                return _objectIdentifierField;
            }
            set
            {
                _objectIdentifierField = value;
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return _mimeTypeField;
            }
            set
            {
                _mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return _encodingField;
            }
            set
            {
                _encodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ObjectReference
        {
            get
            {
                return _objectReferenceField;
            }
            set
            {
                _objectReferenceField = value;
            }
        }
    }
}