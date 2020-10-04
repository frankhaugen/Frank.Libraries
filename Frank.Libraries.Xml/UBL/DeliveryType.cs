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
    [XmlRoot("ContractualDelivery", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class DeliveryType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryDateType ActualDeliveryDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualDeliveryTimeType ActualDeliveryTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryDateType LatestDeliveryDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatestDeliveryTimeType LatestDeliveryTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReleaseIDType ReleaseID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TrackingIDType TrackingID;
    
        /// <remarks/>
        public AddressType DeliveryAddress;
    
        /// <remarks/>
        public LocationType1 DeliveryLocation;
    
        /// <remarks/>
        public LocationType1 AlternativeDeliveryLocation;
    
        /// <remarks/>
        public PeriodType RequestedDeliveryPeriod;
    
        /// <remarks/>
        public PeriodType PromisedDeliveryPeriod;
    
        /// <remarks/>
        public PeriodType EstimatedDeliveryPeriod;
    
        /// <remarks/>
        public PartyType CarrierParty;
    
        /// <remarks/>
        public PartyType DeliveryParty;
    
        /// <remarks/>
        [XmlElement("NotifyParty")]
        public PartyType[] NotifyParty;
    
        /// <remarks/>
        public DespatchType Despatch;
    
        /// <remarks/>
        [XmlElement("DeliveryTerms")]
        public DeliveryTermsType[] DeliveryTerms;
    
        /// <remarks/>
        public DeliveryUnitType MinimumDeliveryUnit;
    
        /// <remarks/>
        public DeliveryUnitType MaximumDeliveryUnit;
    
        /// <remarks/>
        public ShipmentType Shipment;
    }
}