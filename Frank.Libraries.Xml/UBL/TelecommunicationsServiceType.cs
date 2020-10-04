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
    [XmlRoot("TelecommunicationsService", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class TelecommunicationsServiceType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CallDateType CallDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CallTimeType CallTime;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ServiceNumberCalledType ServiceNumberCalled;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsServiceCategoryType TelecommunicationsServiceCategory;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsServiceCategoryCodeType TelecommunicationsServiceCategoryCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MovieTitleType MovieTitle;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoamingPartnerNameType RoamingPartnerName;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PayPerViewType PayPerView;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public QuantityType2 Quantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsServiceCallType TelecommunicationsServiceCall;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TelecommunicationsServiceCallCodeType TelecommunicationsServiceCallCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CallBaseAmountType CallBaseAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CallExtensionAmountType CallExtensionAmount;
    
        /// <remarks/>
        public PriceType Price;
    
        /// <remarks/>
        public CountryType Country;
    
        /// <remarks/>
        [XmlElement("ExchangeRate")]
        public ExchangeRateType[] ExchangeRate;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        [XmlElement("TaxTotal")]
        public TaxTotalType[] TaxTotal;
    
        /// <remarks/>
        [XmlElement("CallDuty")]
        public DutyType1[] CallDuty;
    
        /// <remarks/>
        [XmlElement("TimeDuty")]
        public DutyType1[] TimeDuty;
    }
}