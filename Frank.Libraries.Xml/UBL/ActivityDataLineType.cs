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
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRoot("ActivityDataLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public class ActivityDataLineType
    {

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;

        /// <remarks/>
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode;

        /// <remarks/>
        public CustomerPartyType BuyerCustomerParty;

        /// <remarks/>
        public SupplierPartyType SellerSupplierParty;

        /// <remarks/>
        public PeriodType ActivityPeriod;

        /// <remarks/>
        public LocationType1 ActivityOriginLocation;

        /// <remarks/>
        public LocationType1 ActivityFinalLocation;

        /// <remarks/>
        [XmlElement("SalesItem")]
        public SalesItemType[] SalesItem;
    }
}
