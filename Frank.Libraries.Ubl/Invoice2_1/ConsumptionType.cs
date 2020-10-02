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

        private UtilityStatementTypeCodeType utilityStatementTypeCodeField;

        private PeriodType mainPeriodField;

        private AllowanceChargeType[] allowanceChargeField;

        private TaxTotalType[] taxTotalField;

        private EnergyWaterSupplyType energyWaterSupplyField;

        private TelecommunicationsSupplyType telecommunicationsSupplyField;

        private MonetaryTotalType legalMonetaryTotalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UtilityStatementTypeCodeType UtilityStatementTypeCode
        {
            get
            {
                return utilityStatementTypeCodeField;
            }
            set
            {
                utilityStatementTypeCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType MainPeriod
        {
            get
            {
                return mainPeriodField;
            }
            set
            {
                mainPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return allowanceChargeField;
            }
            set
            {
                allowanceChargeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return taxTotalField;
            }
            set
            {
                taxTotalField = value;
            }
        }

        /// <remarks/>
        public EnergyWaterSupplyType EnergyWaterSupply
        {
            get
            {
                return energyWaterSupplyField;
            }
            set
            {
                energyWaterSupplyField = value;
            }
        }

        /// <remarks/>
        public TelecommunicationsSupplyType TelecommunicationsSupply
        {
            get
            {
                return telecommunicationsSupplyField;
            }
            set
            {
                telecommunicationsSupplyField = value;
            }
        }

        /// <remarks/>
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return legalMonetaryTotalField;
            }
            set
            {
                legalMonetaryTotalField = value;
            }
        }
    }
}