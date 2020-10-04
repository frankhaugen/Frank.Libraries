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
    [XmlRoot("AccountingCustomerParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class CustomerPartyType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomerAssignedAccountIDType CustomerAssignedAccountID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplierAssignedAccountIDType SupplierAssignedAccountID;
    
        /// <remarks/>
        [XmlElement("AdditionalAccountID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalAccountIDType[] AdditionalAccountID;
    
        /// <remarks/>
        public PartyType Party;
    
        /// <remarks/>
        public ContactType DeliveryContact;
    
        /// <remarks/>
        public ContactType AccountingContact;
    
        /// <remarks/>
        public ContactType BuyerContact;
    }
}