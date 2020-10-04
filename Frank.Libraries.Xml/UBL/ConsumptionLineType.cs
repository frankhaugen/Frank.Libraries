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
    [XmlRoot("ConsumptionLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class ConsumptionLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ParentDocumentLineReferenceIDType ParentDocumentLineReferenceID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicedQuantityType InvoicedQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount;
    
        /// <remarks/>
        public PeriodType Period;
    
        /// <remarks/>
        [XmlElement("Delivery")]
        public DeliveryType[] Delivery;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        [XmlElement("TaxTotal")]
        public TaxTotalType[] TaxTotal;
    
        /// <remarks/>
        public UtilityItemType UtilityItem;
    
        /// <remarks/>
        public PriceType Price;
    
        /// <remarks/>
        public UnstructuredPriceType UnstructuredPrice;
    }
}