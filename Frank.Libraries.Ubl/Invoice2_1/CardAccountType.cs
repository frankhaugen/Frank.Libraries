namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CardAccountType
    {

        private PrimaryAccountNumberIdType _primaryAccountNumberIdField;

        private NetworkIdType _networkIdField;

        private CardTypeCodeType _cardTypeCodeField;

        private ValidityStartDateType _validityStartDateField;

        private ExpiryDateType _expiryDateField;

        private IssuerIdType _issuerIdField;

        private IssueNumberIdType _issueNumberIdField;

        private Cv2IdType _cV2IdField;

        private CardChipCodeType _cardChipCodeField;

        private ChipApplicationIdType _chipApplicationIdField;

        private HolderNameType _holderNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrimaryAccountNumberIdType PrimaryAccountNumberId
        {
            get
            {
                return _primaryAccountNumberIdField;
            }
            set
            {
                _primaryAccountNumberIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetworkIdType NetworkId
        {
            get
            {
                return _networkIdField;
            }
            set
            {
                _networkIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardTypeCodeType CardTypeCode
        {
            get
            {
                return _cardTypeCodeField;
            }
            set
            {
                _cardTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidityStartDateType ValidityStartDate
        {
            get
            {
                return _validityStartDateField;
            }
            set
            {
                _validityStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return _expiryDateField;
            }
            set
            {
                _expiryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssuerIdType IssuerId
        {
            get
            {
                return _issuerIdField;
            }
            set
            {
                _issuerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueNumberIdType IssueNumberId
        {
            get
            {
                return _issueNumberIdField;
            }
            set
            {
                _issueNumberIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Cv2IdType Cv2Id
        {
            get
            {
                return _cV2IdField;
            }
            set
            {
                _cV2IdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardChipCodeType CardChipCode
        {
            get
            {
                return _cardChipCodeField;
            }
            set
            {
                _cardChipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChipApplicationIdType ChipApplicationId
        {
            get
            {
                return _chipApplicationIdField;
            }
            set
            {
                _chipApplicationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HolderNameType HolderName
        {
            get
            {
                return _holderNameField;
            }
            set
            {
                _holderNameField = value;
            }
        }
    }
}