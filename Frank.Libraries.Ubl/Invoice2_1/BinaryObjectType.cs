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

        private string formatField;

        private string mimeCodeField;

        private string encodingCodeField;

        private string characterSetCodeField;

        private string uriField;

        private string filenameField;

        private byte[] valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return formatField;
            }
            set
            {
                formatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string mimeCode
        {
            get
            {
                return mimeCodeField;
            }
            set
            {
                mimeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string encodingCode
        {
            get
            {
                return encodingCodeField;
            }
            set
            {
                encodingCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "normalizedString")]
        public string characterSetCode
        {
            get
            {
                return characterSetCodeField;
            }
            set
            {
                characterSetCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return uriField;
            }
            set
            {
                uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return filenameField;
            }
            set
            {
                filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }
}
