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

        private EstimatedOverallContractAmountType _estimatedOverallContractAmountField;

        private TotalAmountType _totalAmountField;

        private TaxIncludedIndicatorType _taxIncludedIndicatorField;

        private MinimumAmountType _minimumAmountField;

        private MaximumAmountType _maximumAmountField;

        private MonetaryScopeType[] _monetaryScopeField;

        private AverageSubsequentContractAmountType _averageSubsequentContractAmountField;

        private TaxCategoryType[] _applicableTaxCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EstimatedOverallContractAmountType EstimatedOverallContractAmount
        {
            get
            {
                return _estimatedOverallContractAmountField;
            }
            set
            {
                _estimatedOverallContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TotalAmountType TotalAmount
        {
            get
            {
                return _totalAmountField;
            }
            set
            {
                _totalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxIncludedIndicatorType TaxIncludedIndicator
        {
            get
            {
                return _taxIncludedIndicatorField;
            }
            set
            {
                _taxIncludedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumAmountType MinimumAmount
        {
            get
            {
                return _minimumAmountField;
            }
            set
            {
                _minimumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumAmountType MaximumAmount
        {
            get
            {
                return _maximumAmountField;
            }
            set
            {
                _maximumAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MonetaryScope", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MonetaryScopeType[] MonetaryScope
        {
            get
            {
                return _monetaryScopeField;
            }
            set
            {
                _monetaryScopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AverageSubsequentContractAmountType AverageSubsequentContractAmount
        {
            get
            {
                return _averageSubsequentContractAmountField;
            }
            set
            {
                _averageSubsequentContractAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory
        {
            get
            {
                return _applicableTaxCategoryField;
            }
            set
            {
                _applicableTaxCategoryField = value;
            }
        }
    }
}