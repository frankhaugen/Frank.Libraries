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

        private IDType idField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DescriptionType[] descriptionField;

        private PartyType notaryPartyField;

        private PartyType agentPartyField;

        private PartyType[] witnessPartyField;

        private DocumentReferenceType[] mandateDocumentReferenceField;

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
        public PartyType NotaryParty
        {
            get
            {
                return notaryPartyField;
            }
            set
            {
                notaryPartyField = value;
            }
        }

        /// <remarks/>
        public PartyType AgentParty
        {
            get
            {
                return agentPartyField;
            }
            set
            {
                agentPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WitnessParty")]
        public PartyType[] WitnessParty
        {
            get
            {
                return witnessPartyField;
            }
            set
            {
                witnessPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MandateDocumentReference")]
        public DocumentReferenceType[] MandateDocumentReference
        {
            get
            {
                return mandateDocumentReferenceField;
            }
            set
            {
                mandateDocumentReferenceField = value;
            }
        }
    }
}