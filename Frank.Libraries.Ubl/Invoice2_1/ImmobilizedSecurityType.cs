namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ImmobilizedSecurityType
    {

        private ImmobilizationCertificateIdType _immobilizationCertificateIdField;

        private SecurityIdType _securityIdField;

        private IssueDateType _issueDateField;

        private FaceValueAmountType _faceValueAmountField;

        private MarketValueAmountType _marketValueAmountField;

        private SharesNumberQuantityType _sharesNumberQuantityField;

        private PartyType _issuerPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ImmobilizationCertificateIdType ImmobilizationCertificateId
        {
            get
            {
                return _immobilizationCertificateIdField;
            }
            set
            {
                _immobilizationCertificateIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SecurityIdType SecurityId
        {
            get
            {
                return _securityIdField;
            }
            set
            {
                _securityIdField = value;
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
        public FaceValueAmountType FaceValueAmount
        {
            get
            {
                return _faceValueAmountField;
            }
            set
            {
                _faceValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarketValueAmountType MarketValueAmount
        {
            get
            {
                return _marketValueAmountField;
            }
            set
            {
                _marketValueAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SharesNumberQuantityType SharesNumberQuantity
        {
            get
            {
                return _sharesNumberQuantityField;
            }
            set
            {
                _sharesNumberQuantityField = value;
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
    }
}