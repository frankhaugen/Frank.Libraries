namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ExternalReferenceType
    {

        private URIType uRIField;

        private DocumentHashType documentHashField;

        private HashAlgorithmMethodType hashAlgorithmMethodField;

        private ExpiryDateType expiryDateField;

        private ExpiryTimeType expiryTimeField;

        private MimeCodeType mimeCodeField;

        private FormatCodeType formatCodeField;

        private EncodingCodeType encodingCodeField;

        private CharacterSetCodeType characterSetCodeField;

        private FileNameType fileNameField;

        private DescriptionType[] descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public URIType URI
        {
            get
            {
                return uRIField;
            }
            set
            {
                uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentHashType DocumentHash
        {
            get
            {
                return documentHashField;
            }
            set
            {
                documentHashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HashAlgorithmMethodType HashAlgorithmMethod
        {
            get
            {
                return hashAlgorithmMethodField;
            }
            set
            {
                hashAlgorithmMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return expiryDateField;
            }
            set
            {
                expiryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryTimeType ExpiryTime
        {
            get
            {
                return expiryTimeField;
            }
            set
            {
                expiryTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MimeCodeType MimeCode
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FormatCodeType FormatCode
        {
            get
            {
                return formatCodeField;
            }
            set
            {
                formatCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EncodingCodeType EncodingCode
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CharacterSetCodeType CharacterSetCode
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FileNameType FileName
        {
            get
            {
                return fileNameField;
            }
            set
            {
                fileNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
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
    }
}