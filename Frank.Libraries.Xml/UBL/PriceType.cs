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
    [XmlRoot("AlternativeConditionPrice", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class PriceType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceAmountType PriceAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BaseQuantityType BaseQuantity;
    
        /// <remarks/>
        [XmlElement("PriceChangeReason", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceChangeReasonType[] PriceChangeReason;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeCodeType PriceTypeCode;
    
        /// <remarks/>
        [XmlElement("PriceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PriceTypeType PriceType1;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public OrderableUnitFactorRateType OrderableUnitFactorRate;
    
        /// <remarks/>
        [XmlElement("ValidityPeriod")]
        public PeriodType[] ValidityPeriod;
    
        /// <remarks/>
        public PriceListType PriceList;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        public ExchangeRateType PricingExchangeRate;
    }
}