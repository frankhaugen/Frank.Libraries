namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UblExtensionType
    {

        private IdType _idField;

        private NameType1 _nameField;

        private ExtensionAgencyIdType _extensionAgencyIdField;

        private ExtensionAgencyNameType _extensionAgencyNameField;

        private ExtensionVersionIdType _extensionVersionIdField;

        private ExtensionAgencyUriType _extensionAgencyUriField;

        private ExtensionUriType _extensionUriField;

        private ExtensionReasonCodeType _extensionReasonCodeField;

        private ExtensionReasonType _extensionReasonField;

        private System.Xml.XmlElement _extensionContentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyIdType ExtensionAgencyId
        {
            get
            {
                return _extensionAgencyIdField;
            }
            set
            {
                _extensionAgencyIdField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyNameType ExtensionAgencyName
        {
            get
            {
                return _extensionAgencyNameField;
            }
            set
            {
                _extensionAgencyNameField = value;
            }
        }

        /// <remarks/>
        public ExtensionVersionIdType ExtensionVersionId
        {
            get
            {
                return _extensionVersionIdField;
            }
            set
            {
                _extensionVersionIdField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyUriType ExtensionAgencyUri
        {
            get
            {
                return _extensionAgencyUriField;
            }
            set
            {
                _extensionAgencyUriField = value;
            }
        }

        /// <remarks/>
        public ExtensionUriType ExtensionUri
        {
            get
            {
                return _extensionUriField;
            }
            set
            {
                _extensionUriField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonCodeType ExtensionReasonCode
        {
            get
            {
                return _extensionReasonCodeField;
            }
            set
            {
                _extensionReasonCodeField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonType ExtensionReason
        {
            get
            {
                return _extensionReasonField;
            }
            set
            {
                _extensionReasonField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement ExtensionContent
        {
            get
            {
                return _extensionContentField;
            }
            set
            {
                _extensionContentField = value;
            }
        }
    }
}