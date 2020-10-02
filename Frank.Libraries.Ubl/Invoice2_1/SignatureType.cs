namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class SignatureType
    {

        private IdType _idField;

        private NoteType[] _noteField;

        private ValidationDateType _validationDateField;

        private ValidationTimeType _validationTimeField;

        private ValidatorIdType _validatorIdField;

        private CanonicalizationMethodType _canonicalizationMethodField;

        private SignatureMethodType _signatureMethodField;

        private PartyType _signatoryPartyField;

        private AttachmentType _digitalSignatureAttachmentField;

        private DocumentReferenceType _originalDocumentReferenceField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDateType ValidationDate
        {
            get
            {
                return _validationDateField;
            }
            set
            {
                _validationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return _validationTimeField;
            }
            set
            {
                _validationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorIdType ValidatorId
        {
            get
            {
                return _validatorIdField;
            }
            set
            {
                _validatorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return _canonicalizationMethodField;
            }
            set
            {
                _canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return _signatureMethodField;
            }
            set
            {
                _signatureMethodField = value;
            }
        }

        /// <remarks/>
        public PartyType SignatoryParty
        {
            get
            {
                return _signatoryPartyField;
            }
            set
            {
                _signatoryPartyField = value;
            }
        }

        /// <remarks/>
        public AttachmentType DigitalSignatureAttachment
        {
            get
            {
                return _digitalSignatureAttachmentField;
            }
            set
            {
                _digitalSignatureAttachmentField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType OriginalDocumentReference
        {
            get
            {
                return _originalDocumentReferenceField;
            }
            set
            {
                _originalDocumentReferenceField = value;
            }
        }
    }
}