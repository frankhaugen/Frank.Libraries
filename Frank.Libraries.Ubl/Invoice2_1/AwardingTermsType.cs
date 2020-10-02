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

        private WeightingAlgorithmCodeType weightingAlgorithmCodeField;

        private DescriptionType[] descriptionField;

        private TechnicalCommitteeDescriptionType[] technicalCommitteeDescriptionField;

        private LowTendersDescriptionType[] lowTendersDescriptionField;

        private PrizeIndicatorType prizeIndicatorField;

        private PrizeDescriptionType[] prizeDescriptionField;

        private PaymentDescriptionType[] paymentDescriptionField;

        private FollowupContractIndicatorType followupContractIndicatorField;

        private BindingOnBuyerIndicatorType bindingOnBuyerIndicatorField;

        private AwardingCriterionType[] awardingCriterionField;

        private PersonType[] technicalCommitteePersonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WeightingAlgorithmCodeType WeightingAlgorithmCode
        {
            get
            {
                return weightingAlgorithmCodeField;
            }
            set
            {
                weightingAlgorithmCodeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TechnicalCommitteeDescriptionType[] TechnicalCommitteeDescription
        {
            get
            {
                return technicalCommitteeDescriptionField;
            }
            set
            {
                technicalCommitteeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LowTendersDescriptionType[] LowTendersDescription
        {
            get
            {
                return lowTendersDescriptionField;
            }
            set
            {
                lowTendersDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeIndicatorType PrizeIndicator
        {
            get
            {
                return prizeIndicatorField;
            }
            set
            {
                prizeIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PrizeDescriptionType[] PrizeDescription
        {
            get
            {
                return prizeDescriptionField;
            }
            set
            {
                prizeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentDescriptionType[] PaymentDescription
        {
            get
            {
                return paymentDescriptionField;
            }
            set
            {
                paymentDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FollowupContractIndicatorType FollowupContractIndicator
        {
            get
            {
                return followupContractIndicatorField;
            }
            set
            {
                followupContractIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BindingOnBuyerIndicatorType BindingOnBuyerIndicator
        {
            get
            {
                return bindingOnBuyerIndicatorField;
            }
            set
            {
                bindingOnBuyerIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AwardingCriterion")]
        public AwardingCriterionType[] AwardingCriterion
        {
            get
            {
                return awardingCriterionField;
            }
            set
            {
                awardingCriterionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson")]
        public PersonType[] TechnicalCommitteePerson
        {
            get
            {
                return technicalCommitteePersonField;
            }
            set
            {
                technicalCommitteePersonField = value;
            }
        }
    }
}