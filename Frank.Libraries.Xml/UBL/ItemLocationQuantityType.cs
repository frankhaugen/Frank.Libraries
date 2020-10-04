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
    [XmlRoot("ItemLocationQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ItemLocationQuantityType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LeadTimeMeasureType LeadTimeMeasure;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MinimumQuantityType MinimumQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MaximumQuantityType MaximumQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HazardousRiskIndicatorType HazardousRiskIndicator;
    
        /// <remarks/>
        [XmlElement("TradingRestrictions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TradingRestrictionsType[] TradingRestrictions;
    
        /// <remarks/>
        [XmlElement("ApplicableTerritoryAddress")]
        public AddressType[] ApplicableTerritoryAddress;
    
        /// <remarks/>
        public PriceType Price;
    
        /// <remarks/>
        [XmlElement("DeliveryUnit")]
        public DeliveryUnitType[] DeliveryUnit;
    
        /// <remarks/>
        [XmlElement("ApplicableTaxCategory")]
        public TaxCategoryType[] ApplicableTaxCategory;
    
        /// <remarks/>
        public PackageType Package;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        public DependentPriceReferenceType DependentPriceReference;
    }
}