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

        private TenderResultCodeType tenderResultCodeField;

        private DescriptionType[] descriptionField;

        private AdvertisementAmountType advertisementAmountField;

        private AwardDateType awardDateField;

        private AwardTimeType awardTimeField;

        private ReceivedTenderQuantityType receivedTenderQuantityField;

        private LowerTenderAmountType lowerTenderAmountField;

        private HigherTenderAmountType higherTenderAmountField;

        private StartDateType startDateField;

        private ReceivedElectronicTenderQuantityType receivedElectronicTenderQuantityField;

        private ReceivedForeignTenderQuantityType receivedForeignTenderQuantityField;

        private ContractType contractField;

        private TenderedProjectType awardedTenderedProjectField;

        private PeriodType contractFormalizationPeriodField;

        private SubcontractTermsType[] subcontractTermsField;

        private WinningPartyType[] winningPartyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TenderResultCodeType TenderResultCode
        {
            get
            {
                return tenderResultCodeField;
            }
            set
            {
                tenderResultCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdvertisementAmountType AdvertisementAmount
        {
            get
            {
                return advertisementAmountField;
            }
            set
            {
                advertisementAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardDateType AwardDate
        {
            get
            {
                return awardDateField;
            }
            set
            {
                awardDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AwardTimeType AwardTime
        {
            get
            {
                return awardTimeField;
            }
            set
            {
                awardTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedTenderQuantityType ReceivedTenderQuantity
        {
            get
            {
                return receivedTenderQuantityField;
            }
            set
            {
                receivedTenderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowerTenderAmountType LowerTenderAmount
        {
            get
            {
                return lowerTenderAmountField;
            }
            set
            {
                lowerTenderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HigherTenderAmountType HigherTenderAmount
        {
            get
            {
                return higherTenderAmountField;
            }
            set
            {
                higherTenderAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StartDateType StartDate
        {
            get
            {
                return startDateField;
            }
            set
            {
                startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedElectronicTenderQuantityType ReceivedElectronicTenderQuantity
        {
            get
            {
                return receivedElectronicTenderQuantityField;
            }
            set
            {
                receivedElectronicTenderQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReceivedForeignTenderQuantityType ReceivedForeignTenderQuantity
        {
            get
            {
                return receivedForeignTenderQuantityField;
            }
            set
            {
                receivedForeignTenderQuantityField = value;
            }
        }

        /// <remarks/>
        public ContractType Contract
        {
            get
            {
                return contractField;
            }
            set
            {
                contractField = value;
            }
        }

        /// <remarks/>
        public TenderedProjectType AwardedTenderedProject
        {
            get
            {
                return awardedTenderedProjectField;
            }
            set
            {
                awardedTenderedProjectField = value;
            }
        }

        /// <remarks/>
        public PeriodType ContractFormalizationPeriod
        {
            get
            {
                return contractFormalizationPeriodField;
            }
            set
            {
                contractFormalizationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubcontractTerms")]
        public SubcontractTermsType[] SubcontractTerms
        {
            get
            {
                return subcontractTermsField;
            }
            set
            {
                subcontractTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WinningParty")]
        public WinningPartyType[] WinningParty
        {
            get
            {
                return winningPartyField;
            }
            set
            {
                winningPartyField = value;
            }
        }
    }
}