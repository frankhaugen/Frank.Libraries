using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("EnergyWaterSupply", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class EnergyWaterSupplyType {
    
        /// <remarks/>
        [XmlElement("ConsumptionReport")]
        public ConsumptionReportType[] ConsumptionReport;
    
        /// <remarks/>
        [XmlElement("EnergyTaxReport")]
        public EnergyTaxReportType[] EnergyTaxReport;
    
        /// <remarks/>
        [XmlElement("ConsumptionAverage")]
        public ConsumptionAverageType[] ConsumptionAverage;
    
        /// <remarks/>
        [XmlElement("EnergyWaterConsumptionCorrection")]
        public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection;
    }
}