namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("Consumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionType
    {

        private UtilityStatementTypeCodeType _utilityStatementTypeCodeField;

        private PeriodType _mainPeriodField;

        private AllowanceChargeType[] _allowanceChargeField;

        private TaxTotalType[] _taxTotalField;

        private EnergyWaterSupplyType _energyWaterSupplyField;

        private TelecommunicationsSupplyType _telecommunicationsSupplyField;

        private MonetaryTotalType _legalMonetaryTotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UtilityStatementTypeCodeType UtilityStatementTypeCode
        {
            get
            {
                return _utilityStatementTypeCodeField;
            }
            set
            {
                _utilityStatementTypeCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType MainPeriod
        {
            get
            {
                return _mainPeriodField;
            }
            set
            {
                _mainPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return _allowanceChargeField;
            }
            set
            {
                _allowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return _taxTotalField;
            }
            set
            {
                _taxTotalField = value;
            }
        }

        /// <remarks/>
        public EnergyWaterSupplyType EnergyWaterSupply
        {
            get
            {
                return _energyWaterSupplyField;
            }
            set
            {
                _energyWaterSupplyField = value;
            }
        }

        /// <remarks/>
        public TelecommunicationsSupplyType TelecommunicationsSupply
        {
            get
            {
                return _telecommunicationsSupplyField;
            }
            set
            {
                _telecommunicationsSupplyField = value;
            }
        }

        /// <remarks/>
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return _legalMonetaryTotalField;
            }
            set
            {
                _legalMonetaryTotalField = value;
            }
        }
    }
}