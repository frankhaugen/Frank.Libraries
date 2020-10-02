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

        private ConsumptionReportType[] _consumptionReportField;

        private EnergyTaxReportType[] _energyTaxReportField;

        private ConsumptionAverageType[] _consumptionAverageField;

        private ConsumptionCorrectionType[] _energyWaterConsumptionCorrectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReport")]
        public ConsumptionReportType[] ConsumptionReport
        {
            get
            {
                return _consumptionReportField;
            }
            set
            {
                _consumptionReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport")]
        public EnergyTaxReportType[] EnergyTaxReport
        {
            get
            {
                return _energyTaxReportField;
            }
            set
            {
                _energyTaxReportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage")]
        public ConsumptionAverageType[] ConsumptionAverage
        {
            get
            {
                return _consumptionAverageField;
            }
            set
            {
                _consumptionAverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnergyWaterConsumptionCorrection")]
        public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection
        {
            get
            {
                return _energyWaterConsumptionCorrectionField;
            }
            set
            {
                _energyWaterConsumptionCorrectionField = value;
            }
        }
    }
}