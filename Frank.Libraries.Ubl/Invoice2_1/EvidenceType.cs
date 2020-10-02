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

        private IDType idField;

        private EvidenceTypeCodeType evidenceTypeCodeField;

        private DescriptionType[] descriptionField;

        private CandidateStatementType[] candidateStatementField;

        private PartyType evidenceIssuingPartyField;

        private DocumentReferenceType documentReferenceField;

        private LanguageType languageField;

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
        public EvidenceTypeCodeType EvidenceTypeCode
        {
            get
            {
                return evidenceTypeCodeField;
            }
            set
            {
                evidenceTypeCodeField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CandidateStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CandidateStatementType[] CandidateStatement
        {
            get
            {
                return candidateStatementField;
            }
            set
            {
                candidateStatementField = value;
            }
        }

        /// <remarks/>
        public PartyType EvidenceIssuingParty
        {
            get
            {
                return evidenceIssuingPartyField;
            }
            set
            {
                evidenceIssuingPartyField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        public LanguageType Language
        {
            get
            {
                return languageField;
            }
            set
            {
                languageField = value;
            }
        }
    }
}