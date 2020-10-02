namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DocumentReferenceType
    {

        private IdType _idField;

        private CopyIndicatorType _copyIndicatorField;

        private UuidType _uUidField;

        private IssueDateType _issueDateField;

        private IssueTimeType _issueTimeField;

        private DocumentTypeCodeType _documentTypeCodeField;

        private DocumentTypeType _documentTypeField;

        private XPathType[] _xPathField;

        private LanguageIdType _languageIdField;

        private LocaleCodeType _localeCodeField;

        private VersionIdType _versionIdField;

        private DocumentStatusCodeType _documentStatusCodeField;

        private DocumentDescriptionType[] _documentDescriptionField;

        private AttachmentType _attachmentField;

        private PeriodType _validityPeriodField;

        private PartyType _issuerPartyField;

        private ResultOfVerificationType _resultOfVerificationField;

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
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return _copyIndicatorField;
            }
            set
            {
                _copyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UuidType Uuid
        {
            get
            {
                return _uUidField;
            }
            set
            {
                _uUidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return _issueDateField;
            }
            set
            {
                _issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return _issueTimeField;
            }
            set
            {
                _issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentTypeCodeType DocumentTypeCode
        {
            get
            {
                return _documentTypeCodeField;
            }
            set
            {
                _documentTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentTypeType DocumentType
        {
            get
            {
                return _documentTypeField;
            }
            set
            {
                _documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public XPathType[] XPath
        {
            get
            {
                return _xPathField;
            }
            set
            {
                _xPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LanguageIdType LanguageId
        {
            get
            {
                return _languageIdField;
            }
            set
            {
                _languageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocaleCodeType LocaleCode
        {
            get
            {
                return _localeCodeField;
            }
            set
            {
                _localeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionIdType VersionId
        {
            get
            {
                return _versionIdField;
            }
            set
            {
                _versionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentStatusCodeType DocumentStatusCode
        {
            get
            {
                return _documentStatusCodeField;
            }
            set
            {
                _documentStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentDescriptionType[] DocumentDescription
        {
            get
            {
                return _documentDescriptionField;
            }
            set
            {
                _documentDescriptionField = value;
            }
        }

        /// <remarks/>
        public AttachmentType Attachment
        {
            get
            {
                return _attachmentField;
            }
            set
            {
                _attachmentField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return _validityPeriodField;
            }
            set
            {
                _validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return _issuerPartyField;
            }
            set
            {
                _issuerPartyField = value;
            }
        }

        /// <remarks/>
        public ResultOfVerificationType ResultOfVerification
        {
            get
            {
                return _resultOfVerificationField;
            }
            set
            {
                _resultOfVerificationField = value;
            }
        }
    }
}