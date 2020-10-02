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

        private IDType idField;

        private CopyIndicatorType copyIndicatorField;

        private UUIDType uUIDField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DocumentTypeCodeType documentTypeCodeField;

        private DocumentTypeType documentTypeField;

        private XPathType[] xPathField;

        private LanguageIDType languageIDField;

        private LocaleCodeType localeCodeField;

        private VersionIDType versionIDField;

        private DocumentStatusCodeType documentStatusCodeField;

        private DocumentDescriptionType[] documentDescriptionField;

        private AttachmentType attachmentField;

        private PeriodType validityPeriodField;

        private PartyType issuerPartyField;

        private ResultOfVerificationType resultOfVerificationField;

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
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return copyIndicatorField;
            }
            set
            {
                copyIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return uUIDField;
            }
            set
            {
                uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return issueDateField;
            }
            set
            {
                issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return issueTimeField;
            }
            set
            {
                issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentTypeCodeType DocumentTypeCode
        {
            get
            {
                return documentTypeCodeField;
            }
            set
            {
                documentTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentTypeType DocumentType
        {
            get
            {
                return documentTypeField;
            }
            set
            {
                documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public XPathType[] XPath
        {
            get
            {
                return xPathField;
            }
            set
            {
                xPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LanguageIDType LanguageID
        {
            get
            {
                return languageIDField;
            }
            set
            {
                languageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LocaleCodeType LocaleCode
        {
            get
            {
                return localeCodeField;
            }
            set
            {
                localeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public VersionIDType VersionID
        {
            get
            {
                return versionIDField;
            }
            set
            {
                versionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentStatusCodeType DocumentStatusCode
        {
            get
            {
                return documentStatusCodeField;
            }
            set
            {
                documentStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentDescriptionType[] DocumentDescription
        {
            get
            {
                return documentDescriptionField;
            }
            set
            {
                documentDescriptionField = value;
            }
        }

        /// <remarks/>
        public AttachmentType Attachment
        {
            get
            {
                return attachmentField;
            }
            set
            {
                attachmentField = value;
            }
        }

        /// <remarks/>
        public PeriodType ValidityPeriod
        {
            get
            {
                return validityPeriodField;
            }
            set
            {
                validityPeriodField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return issuerPartyField;
            }
            set
            {
                issuerPartyField = value;
            }
        }

        /// <remarks/>
        public ResultOfVerificationType ResultOfVerification
        {
            get
            {
                return resultOfVerificationField;
            }
            set
            {
                resultOfVerificationField = value;
            }
        }
    }
}