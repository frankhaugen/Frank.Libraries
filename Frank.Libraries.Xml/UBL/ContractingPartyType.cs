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
    [XmlRoot("ContractingParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ContractingPartyType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerProfileURIType BuyerProfileURI;
    
        /// <remarks/>
        [XmlElement("ContractingPartyType")]
        public ContractingPartyTypeType[] ContractingPartyType1;
    
        /// <remarks/>
        [XmlElement("ContractingActivity")]
        public ContractingActivityType[] ContractingActivity;
    
        /// <remarks/>
        public PartyType Party;
    }
}