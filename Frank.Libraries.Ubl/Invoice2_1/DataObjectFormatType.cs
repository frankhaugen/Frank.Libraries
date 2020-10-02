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

        private string descriptionField;

        private ObjectIdentifierType objectIdentifierField;

        private string mimeTypeField;

        private string encodingField;

        private string objectReferenceField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        public ObjectIdentifierType ObjectIdentifier
        {
            get
            {
                return objectIdentifierField;
            }
            set
            {
                objectIdentifierField = value;
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return mimeTypeField;
            }
            set
            {
                mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
        public string Encoding
        {
            get
            {
                return encodingField;
            }
            set
            {
                encodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ObjectReference
        {
            get
            {
                return objectReferenceField;
            }
            set
            {
                objectReferenceField = value;
            }
        }
    }
}