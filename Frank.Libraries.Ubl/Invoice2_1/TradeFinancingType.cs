namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TradeFinancing", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TradeFinancingType
    {

        private IdType _idField;

        private FinancingInstrumentCodeType _financingInstrumentCodeField;

        private DocumentReferenceType _contractDocumentReferenceField;

        private DocumentReferenceType[] _documentReferenceField;

        private PartyType _financingPartyField;

        private FinancialAccountType _financingFinancialAccountField;

        private ClauseType[] _clauseField;

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
        public FinancingInstrumentCodeType FinancingInstrumentCode
        {
            get
            {
                return _financingInstrumentCodeField;
            }
            set
            {
                _financingInstrumentCodeField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType ContractDocumentReference
        {
            get
            {
                return _contractDocumentReferenceField;
            }
            set
            {
                _contractDocumentReferenceField = value;
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
        public PartyType FinancingParty
        {
            get
            {
                return _financingPartyField;
            }
            set
            {
                _financingPartyField = value;
            }
        }

        /// <remarks/>
        public FinancialAccountType FinancingFinancialAccount
        {
            get
            {
                return _financingFinancialAccountField;
            }
            set
            {
                _financingFinancialAccountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Clause")]
        public ClauseType[] Clause
        {
            get
            {
                return _clauseField;
            }
            set
            {
                _clauseField = value;
            }
        }
    }
}