namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("RequestedTenderTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class RequestedTenderTotalType
    {

        private EstimatedOverallContractAmountType estimatedOverallContractAmountField;

        private TotalAmountType totalAmountField;

        private TaxIncludedIndicatorType taxIncludedIndicatorField;

        private MinimumAmountType minimumAmountField;

        private MaximumAmountType maximumAmountField;

        private MonetaryScopeType[] monetaryScopeField;

        private AverageSubsequentContractAmountType averageSubsequentContractAmountField;

        private TaxCategoryType[] applicableTaxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractAmountType EstimatedOverallContractAmount
        {
            get
            {
                return estimatedOverallContractAmountField;
            }
            set
            {
                estimatedOverallContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalAmountType TotalAmount
        {
            get
            {
                return totalAmountField;
            }
            set
            {
                totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return taxIncludedIndicatorField;
            }
            set
            {
                taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return minimumAmountField;
            }
            set
            {
                minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return maximumAmountField;
            }
            set
            {
                maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MonetaryScopeType[] MonetaryScope
        {
            get
            {
                return monetaryScopeField;
            }
            set
            {
                monetaryScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AverageSubsequentContractAmountType AverageSubsequentContractAmount
        {
            get
            {
                return averageSubsequentContractAmountField;
            }
            set
            {
                averageSubsequentContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return applicableTaxCategoryField;
            }
            set
            {
                applicableTaxCategoryField = value;
            }
        }
    }
}