namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EmbassyEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EndorsementType
    {

        private DocumentIDType documentIDField;

        private ApprovalStatusType approvalStatusField;

        private RemarksType[] remarksField;

        private EndorserPartyType endorserPartyField;

        private SignatureType[] signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentIDType DocumentID
        {
            get
            {
                return documentIDField;
            }
            set
            {
                documentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ApprovalStatusType ApprovalStatus
        {
            get
            {
                return approvalStatusField;
            }
            set
            {
                approvalStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RemarksType[] Remarks
        {
            get
            {
                return remarksField;
            }
            set
            {
                remarksField = value;
            }
        }

        /// <remarks/>
        public EndorserPartyType EndorserParty
        {
            get
            {
                return endorserPartyField;
            }
            set
            {
                endorserPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
        public SignatureType[] Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }
    }
}