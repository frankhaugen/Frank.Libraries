namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("TenderResult", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class TenderResultType
    {

        private TenderResultCodeType _tenderResultCodeField;

        private DescriptionType[] _descriptionField;

        private AdvertisementAmountType _advertisementAmountField;

        private AwardDateType _awardDateField;

        private AwardTimeType _awardTimeField;

        private ReceivedTenderQuantityType _receivedTenderQuantityField;

        private LowerTenderAmountType _lowerTenderAmountField;

        private HigherTenderAmountType _higherTenderAmountField;

        private StartDateType _startDateField;

        private ReceivedElectronicTenderQuantityType _receivedElectronicTenderQuantityField;

        private ReceivedForeignTenderQuantityType _receivedForeignTenderQuantityField;

        private ContractType _contractField;

        private TenderedProjectType _awardedTenderedProjectField;

        private PeriodType _contractFormalizationPeriodField;

        private SubcontractTermsType[] _subcontractTermsField;

        private WinningPartyType[] _winningPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderResultCodeType TenderResultCode
        {
            get
            {
                return _tenderResultCodeField;
            }
            set
            {
                _tenderResultCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdvertisementAmountType AdvertisementAmount
        {
            get
            {
                return _advertisementAmountField;
            }
            set
            {
                _advertisementAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardDateType AwardDate
        {
            get
            {
                return _awardDateField;
            }
            set
            {
                _awardDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardTimeType AwardTime
        {
            get
            {
                return _awardTimeField;
            }
            set
            {
                _awardTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedTenderQuantityType ReceivedTenderQuantity
        {
            get
            {
                return _receivedTenderQuantityField;
            }
            set
            {
                _receivedTenderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowerTenderAmountType LowerTenderAmount
        {
            get
            {
                return _lowerTenderAmountField;
            }
            set
            {
                _lowerTenderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HigherTenderAmountType HigherTenderAmount
        {
            get
            {
                return _higherTenderAmountField;
            }
            set
            {
                _higherTenderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StartDateType StartDate
        {
            get
            {
                return _startDateField;
            }
            set
            {
                _startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedElectronicTenderQuantityType ReceivedElectronicTenderQuantity
        {
            get
            {
                return _receivedElectronicTenderQuantityField;
            }
            set
            {
                _receivedElectronicTenderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedForeignTenderQuantityType ReceivedForeignTenderQuantity
        {
            get
            {
                return _receivedForeignTenderQuantityField;
            }
            set
            {
                _receivedForeignTenderQuantityField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return _contractField;
            }
            set
            {
                _contractField = value;
            }
        }

        /// <remarks/>
        public TenderedProjectType AwardedTenderedProject
        {
            get
            {
                return _awardedTenderedProjectField;
            }
            set
            {
                _awardedTenderedProjectField = value;
            }
        }

        /// <remarks/>
        public PeriodType ContractFormalizationPeriod
        {
            get
            {
                return _contractFormalizationPeriodField;
            }
            set
            {
                _contractFormalizationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubcontractTerms")]
        public SubcontractTermsType[] SubcontractTerms
        {
            get
            {
                return _subcontractTermsField;
            }
            set
            {
                _subcontractTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WinningParty")]
        public WinningPartyType[] WinningParty
        {
            get
            {
                return _winningPartyField;
            }
            set
            {
                _winningPartyField = value;
            }
        }
    }
}