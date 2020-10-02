namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EnergyWaterSupplyType
    {

        private ConsumptionReportType[] consumptionReportField;

        private EnergyTaxReportType[] energyTaxReportField;

        private ConsumptionAverageType[] consumptionAverageField;

        private ConsumptionCorrectionType[] energyWaterConsumptionCorrectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReport")]
        public ConsumptionReportType[] ConsumptionReport
        {
            get
            {
                return consumptionReportField;
            }
            set
            {
                consumptionReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport")]
        public EnergyTaxReportType[] EnergyTaxReport
        {
            get
            {
                return energyTaxReportField;
            }
            set
            {
                energyTaxReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage")]
        public ConsumptionAverageType[] ConsumptionAverage
        {
            get
            {
                return consumptionAverageField;
            }
            set
            {
                consumptionAverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyWaterConsumptionCorrection")]
        public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection
        {
            get
            {
                return energyWaterConsumptionCorrectionField;
            }
            set
            {
                energyWaterConsumptionCorrectionField = value;
            }
        }
    }
}