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
    [XmlRoot("BillingReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class BillingReferenceType {
    
        /// <remarks/>
        public DocumentReferenceType InvoiceDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType SelfBilledInvoiceDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType CreditNoteDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType DebitNoteDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType ReminderDocumentReference;
    
        /// <remarks/>
        public DocumentReferenceType AdditionalDocumentReference;
    
        /// <remarks/>
        [XmlElement("BillingReferenceLine")]
        public BillingReferenceLineType[] BillingReferenceLine;
    }
}