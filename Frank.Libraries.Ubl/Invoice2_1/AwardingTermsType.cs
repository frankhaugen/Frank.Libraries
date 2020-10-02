namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AwardingTermsType
    {

        private WeightingAlgorithmCodeType _weightingAlgorithmCodeField;

        private DescriptionType[] _descriptionField;

        private TechnicalCommitteeDescriptionType[] _technicalCommitteeDescriptionField;

        private LowTendersDescriptionType[] _lowTendersDescriptionField;

        private PrizeIndicatorType _prizeIndicatorField;

        private PrizeDescriptionType[] _prizeDescriptionField;

        private PaymentDescriptionType[] _paymentDescriptionField;

        private FollowupContractIndicatorType _followupContractIndicatorField;

        private BindingOnBuyerIndicatorType _bindingOnBuyerIndicatorField;

        private AwardingCriterionType[] _awardingCriterionField;

        private PersonType[] _technicalCommitteePersonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightingAlgorithmCodeType WeightingAlgorithmCode
        {
            get
            {
                return _weightingAlgorithmCodeField;
            }
            set
            {
                _weightingAlgorithmCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription
        {
            get
            {
                return _technicalCommitteeDescriptionField;
            }
            set
            {
                _technicalCommitteeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowTendersDescriptionType[] LowTendersDescription
        {
            get
            {
                return _lowTendersDescriptionField;
            }
            set
            {
                _lowTendersDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeIndicatorType PrizeIndicator
        {
            get
            {
                return _prizeIndicatorField;
            }
            set
            {
                _prizeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeDescriptionType[] PrizeDescription
        {
            get
            {
                return _prizeDescriptionField;
            }
            set
            {
                _prizeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDescriptionType[] PaymentDescription
        {
            get
            {
                return _paymentDescriptionField;
            }
            set
            {
                _paymentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FollowupContractIndicatorType FollowupContractIndicator
        {
            get
            {
                return _followupContractIndicatorField;
            }
            set
            {
                _followupContractIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BindingOnBuyerIndicatorType BindingOnBuyerIndicator
        {
            get
            {
                return _bindingOnBuyerIndicatorField;
            }
            set
            {
                _bindingOnBuyerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriterion")]
        public AwardingCriterionType[] AwardingCriterion
        {
            get
            {
                return _awardingCriterionField;
            }
            set
            {
                _awardingCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson")]
        public PersonType[] TechnicalCommitteePerson
        {
            get
            {
                return _technicalCommitteePersonField;
            }
            set
            {
                _technicalCommitteePersonField = value;
            }
        }
    }
}