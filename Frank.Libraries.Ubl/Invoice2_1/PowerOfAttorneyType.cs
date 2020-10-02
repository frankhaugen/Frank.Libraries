namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("PowerOfAttorney", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class PowerOfAttorneyType
    {

        private IdType _idField;

        private IssueDateType _issueDateField;

        private IssueTimeType _issueTimeField;

        private DescriptionType[] _descriptionField;

        private PartyType _notaryPartyField;

        private PartyType _agentPartyField;

        private PartyType[] _witnessPartyField;

        private DocumentReferenceType[] _mandateDocumentReferenceField;

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
        public PartyType NotaryParty
        {
            get
            {
                return _notaryPartyField;
            }
            set
            {
                _notaryPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType AgentParty
        {
            get
            {
                return _agentPartyField;
            }
            set
            {
                _agentPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WitnessParty")]
        public PartyType[] WitnessParty
        {
            get
            {
                return _witnessPartyField;
            }
            set
            {
                _witnessPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MandateDocumentReference")]
        public DocumentReferenceType[] MandateDocumentReference
        {
            get
            {
                return _mandateDocumentReferenceField;
            }
            set
            {
                _mandateDocumentReferenceField = value;
            }
        }
    }
}