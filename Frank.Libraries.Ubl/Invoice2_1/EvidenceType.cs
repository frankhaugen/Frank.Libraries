namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Evidence", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EvidenceType
    {

        private IdType _idField;

        private EvidenceTypeCodeType _evidenceTypeCodeField;

        private DescriptionType[] _descriptionField;

        private CandidateStatementType[] _candidateStatementField;

        private PartyType _evidenceIssuingPartyField;

        private DocumentReferenceType _documentReferenceField;

        private LanguageType _languageField;

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
        public EvidenceTypeCodeType EvidenceTypeCode
        {
            get
            {
                return _evidenceTypeCodeField;
            }
            set
            {
                _evidenceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CandidateStatementType[] CandidateStatement
        {
            get
            {
                return _candidateStatementField;
            }
            set
            {
                _candidateStatementField = value;
            }
        }

        /// <remarks/>
        public PartyType EvidenceIssuingParty
        {
            get
            {
                return _evidenceIssuingPartyField;
            }
            set
            {
                _evidenceIssuingPartyField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }

        /// <remarks/>
        public LanguageType Language
        {
            get
            {
                return _languageField;
            }
            set
            {
                _languageField = value;
            }
        }
    }
}