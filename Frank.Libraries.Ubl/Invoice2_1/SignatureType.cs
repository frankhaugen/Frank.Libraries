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

        private IDType idField;

        private NoteType[] noteField;

        private ValidationDateType validationDateField;

        private ValidationTimeType validationTimeField;

        private ValidatorIDType validatorIDField;

        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private PartyType signatoryPartyField;

        private AttachmentType digitalSignatureAttachmentField;

        private DocumentReferenceType originalDocumentReferenceField;

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
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return noteField;
            }
            set
            {
                noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationDateType ValidationDate
        {
            get
            {
                return validationDateField;
            }
            set
            {
                validationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidationTimeType ValidationTime
        {
            get
            {
                return validationTimeField;
            }
            set
            {
                validationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidatorIDType ValidatorID
        {
            get
            {
                return validatorIDField;
            }
            set
            {
                validatorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                return canonicalizationMethodField;
            }
            set
            {
                canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SignatureMethodType SignatureMethod
        {
            get
            {
                return signatureMethodField;
            }
            set
            {
                signatureMethodField = value;
            }
        }

        /// <remarks/>
        public PartyType SignatoryParty
        {
            get
            {
                return signatoryPartyField;
            }
            set
            {
                signatoryPartyField = value;
            }
        }

        /// <remarks/>
        public AttachmentType DigitalSignatureAttachment
        {
            get
            {
                return digitalSignatureAttachmentField;
            }
            set
            {
                digitalSignatureAttachmentField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType OriginalDocumentReference
        {
            get
            {
                return originalDocumentReferenceField;
            }
            set
            {
                originalDocumentReferenceField = value;
            }
        }
    }
}