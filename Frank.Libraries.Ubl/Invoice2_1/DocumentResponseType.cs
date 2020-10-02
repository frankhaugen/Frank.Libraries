namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalDocumentResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class DocumentResponseType
    {

        private ResponseType responseField;

        private DocumentReferenceType[] documentReferenceField;

        private PartyType issuerPartyField;

        private PartyType recipientPartyField;

        private LineResponseType[] lineResponseField;

        /// <remarks/>
        public ResponseType Response
        {
            get
            {
                return responseField;
            }
            set
            {
                responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
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
        public PartyType RecipientParty
        {
            get
            {
                return recipientPartyField;
            }
            set
            {
                recipientPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineResponse")]
        public LineResponseType[] LineResponse
        {
            get
            {
                return lineResponseField;
            }
            set
            {
                lineResponseField = value;
            }
        }
    }
}