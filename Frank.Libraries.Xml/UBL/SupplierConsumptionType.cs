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
    [XmlRoot("SupplierConsumption", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class SupplierConsumptionType {
    
        /// <remarks/>
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description;
    
        /// <remarks/>
        public PartyType UtilitySupplierParty;
    
        /// <remarks/>
        public PartyType UtilityCustomerParty;
    
        /// <remarks/>
        public ConsumptionType Consumption;
    
        /// <remarks/>
        public ContractType Contract;
    
        /// <remarks/>
        [XmlElement("ConsumptionLine")]
        public ConsumptionLineType[] ConsumptionLine;
    }
}