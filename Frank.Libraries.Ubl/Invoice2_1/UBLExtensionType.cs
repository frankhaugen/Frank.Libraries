namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("UBLExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", IsNullable = false)]
    public partial class UBLExtensionType
    {

        private IDType idField;

        private NameType1 nameField;

        private ExtensionAgencyIDType extensionAgencyIDField;

        private ExtensionAgencyNameType extensionAgencyNameField;

        private ExtensionVersionIDType extensionVersionIDField;

        private ExtensionAgencyURIType extensionAgencyURIField;

        private ExtensionURIType extensionURIField;

        private ExtensionReasonCodeType extensionReasonCodeField;

        private ExtensionReasonType extensionReasonField;

        private System.Xml.XmlElement extensionContentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyIDType ExtensionAgencyID
        {
            get
            {
                return extensionAgencyIDField;
            }
            set
            {
                extensionAgencyIDField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyNameType ExtensionAgencyName
        {
            get
            {
                return extensionAgencyNameField;
            }
            set
            {
                extensionAgencyNameField = value;
            }
        }

        /// <remarks/>
        public ExtensionVersionIDType ExtensionVersionID
        {
            get
            {
                return extensionVersionIDField;
            }
            set
            {
                extensionVersionIDField = value;
            }
        }

        /// <remarks/>
        public ExtensionAgencyURIType ExtensionAgencyURI
        {
            get
            {
                return extensionAgencyURIField;
            }
            set
            {
                extensionAgencyURIField = value;
            }
        }

        /// <remarks/>
        public ExtensionURIType ExtensionURI
        {
            get
            {
                return extensionURIField;
            }
            set
            {
                extensionURIField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonCodeType ExtensionReasonCode
        {
            get
            {
                return extensionReasonCodeField;
            }
            set
            {
                extensionReasonCodeField = value;
            }
        }

        /// <remarks/>
        public ExtensionReasonType ExtensionReason
        {
            get
            {
                return extensionReasonField;
            }
            set
            {
                extensionReasonField = value;
            }
        }

        /// <remarks/>
        public System.Xml.XmlElement ExtensionContent
        {
            get
            {
                return extensionContentField;
            }
            set
            {
                extensionContentField = value;
            }
        }
    }
}