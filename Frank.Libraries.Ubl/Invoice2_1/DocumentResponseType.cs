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

        private ResponseType _responseField;

        private DocumentReferenceType[] _documentReferenceField;

        private PartyType _issuerPartyField;

        private PartyType _recipientPartyField;

        private LineResponseType[] _lineResponseField;

        /// <remarks/>
        public ResponseType Response
        {
            get
            {
                return _responseField;
            }
            set
            {
                _responseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
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
        public PartyType RecipientParty
        {
            get
            {
                return _recipientPartyField;
            }
            set
            {
                _recipientPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineResponse")]
        public LineResponseType[] LineResponse
        {
            get
            {
                return _lineResponseField;
            }
            set
            {
                _lineResponseField = value;
            }
        }
    }
}