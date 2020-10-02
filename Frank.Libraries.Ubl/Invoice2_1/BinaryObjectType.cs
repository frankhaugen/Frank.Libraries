namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoundType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PictureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GraphicType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BinaryObjectType1))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class BinaryObjectType
    {

        private string _formatField;

        private string _mimeCodeField;

        private string _encodingCodeField;

        private string _characterSetCodeField;

        private string _uriField;

        private string _filenameField;

        private byte[] _valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format
        {
            get
            {
                return _formatField;
            }
            set
            {
                _formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string MimeCode
        {
            get
            {
                return _mimeCodeField;
            }
            set
            {
                _mimeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string EncodingCode
        {
            get
            {
                return _encodingCodeField;
            }
            set
            {
                _encodingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string CharacterSetCode
        {
            get
            {
                return _characterSetCodeField;
            }
            set
            {
                _characterSetCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Uri
        {
            get
            {
                return _uriField;
            }
            set
            {
                _uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Filename
        {
            get
            {
                return _filenameField;
            }
            set
            {
                _filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return _valueField;
            }
            set
            {
                _valueField = value;
            }
        }
    }
}
