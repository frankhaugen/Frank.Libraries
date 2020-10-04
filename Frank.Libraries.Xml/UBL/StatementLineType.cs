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
    [XmlRoot("StatementLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class StatementLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BalanceBroughtForwardIndicatorType BalanceBroughtForwardIndicator;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DebitLineAmountType DebitLineAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CreditLineAmountType CreditLineAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BalanceAmountType BalanceAmount;
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentPurposeCodeType PaymentPurposeCode;
    
        /// <remarks/>
        public PaymentMeansType PaymentMeans;
    
        /// <remarks/>
        [XmlElement("PaymentTerms")]
        public PaymentTermsType[] PaymentTerms;
    
        /// <remarks/>
        public CustomerPartyType BuyerCustomerParty;
    
        /// <remarks/>
        public SupplierPartyType SellerSupplierParty;
    
        /// <remarks/>
        public CustomerPartyType OriginatorCustomerParty;
    
        /// <remarks/>
        public CustomerPartyType AccountingCustomerParty;
    
        /// <remarks/>
        public SupplierPartyType AccountingSupplierParty;
    
        /// <remarks/>
        public PartyType PayeeParty;
    
        /// <remarks/>
        [XmlElement("InvoicePeriod")]
        public PeriodType[] InvoicePeriod;
    
        /// <remarks/>
        [XmlElement("BillingReference")]
        public BillingReferenceType[] BillingReference;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    
        /// <remarks/>
        public ExchangeRateType ExchangeRate;
    
        /// <remarks/>
        [XmlElement("AllowanceCharge")]
        public AllowanceChargeType[] AllowanceCharge;
    
        /// <remarks/>
        [XmlElement("CollectedPayment")]
        public PaymentType[] CollectedPayment;
    }
}