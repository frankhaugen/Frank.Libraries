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
    [XmlRoot("InvoiceLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class InvoiceLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoicedQuantityType InvoicedQuantity;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineExtensionAmountType LineExtensionAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDateType TaxPointDate;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FreeOfChargeIndicatorType FreeOfChargeIndicator;
    
        /// <remarks/>
        [XmlElement("InvoicePeriod")]
        public PeriodType[] InvoicePeriod;
    
        /// <remarks/>
        [XmlElement("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference;
    
        /// <remarks/>
        [XmlElement("DespatchLineReference")]
        public LineReferenceType[] DespatchLineReference;
    
        /// <remarks/>
        [XmlElement("ReceiptLineReference")]
        public LineReferenceType[] ReceiptLineReference;
    
        /// <remarks/>
        [XmlElement("BillingReference")]
        public BillingReferenceType[] BillingReference;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    
        /// <remarks/>
        public PricingReferenceType PricingReference;
    
        /// <remarks/>
        public PartyType OriginatorParty;
    
        /// <remarks/>
        [XmlElement("Delivery")]
        public DeliveryType[] Delivery;
    
        /// <remarks/>
        [XmlElement("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        [XmlElement("TaxTotal")]
        public TaxTotalType[] TaxTotal;
    
        /// <remarks/>
        [XmlElement("WithholdingTaxTotal")]
        public TaxTotalType[] WithholdingTaxTotal;
    
        /// <remarks/>
        public ItemType Item;
    
        /// <remarks/>
        public PriceType Price;
    
        /// <remarks/>
        public DeliveryTermsType DeliveryTerms;
    
        /// <remarks/>
        [XmlElement("SubInvoiceLine")]
        public InvoiceLineType[] SubInvoiceLine;
    
        /// <remarks/>
        public PriceExtensionType ItemPriceExtension;
    }
}