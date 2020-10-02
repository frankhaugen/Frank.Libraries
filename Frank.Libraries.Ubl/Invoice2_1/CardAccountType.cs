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

        private PrimaryAccountNumberIDType primaryAccountNumberIDField;

        private NetworkIDType networkIDField;

        private CardTypeCodeType cardTypeCodeField;

        private ValidityStartDateType validityStartDateField;

        private ExpiryDateType expiryDateField;

        private IssuerIDType issuerIDField;

        private IssueNumberIDType issueNumberIDField;

        private CV2IDType cV2IDField;

        private CardChipCodeType cardChipCodeField;

        private ChipApplicationIDType chipApplicationIDField;

        private HolderNameType holderNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrimaryAccountNumberIDType PrimaryAccountNumberID
        {
            get
            {
                return primaryAccountNumberIDField;
            }
            set
            {
                primaryAccountNumberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NetworkIDType NetworkID
        {
            get
            {
                return networkIDField;
            }
            set
            {
                networkIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardTypeCodeType CardTypeCode
        {
            get
            {
                return cardTypeCodeField;
            }
            set
            {
                cardTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValidityStartDateType ValidityStartDate
        {
            get
            {
                return validityStartDateField;
            }
            set
            {
                validityStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return expiryDateField;
            }
            set
            {
                expiryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssuerIDType IssuerID
        {
            get
            {
                return issuerIDField;
            }
            set
            {
                issuerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueNumberIDType IssueNumberID
        {
            get
            {
                return issueNumberIDField;
            }
            set
            {
                issueNumberIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CV2IDType CV2ID
        {
            get
            {
                return cV2IDField;
            }
            set
            {
                cV2IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CardChipCodeType CardChipCode
        {
            get
            {
                return cardChipCodeField;
            }
            set
            {
                cardChipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ChipApplicationIDType ChipApplicationID
        {
            get
            {
                return chipApplicationIDField;
            }
            set
            {
                chipApplicationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HolderNameType HolderName
        {
            get
            {
                return holderNameField;
            }
            set
            {
                holderNameField = value;
            }
        }
    }
}