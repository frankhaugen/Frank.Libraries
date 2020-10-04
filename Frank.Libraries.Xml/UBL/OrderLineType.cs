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
    [XmlRoot("OrderLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
    public class OrderLineType {
    
        /// <remarks/>
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubstitutionStatusCodeType SubstitutionStatusCode;
    
        /// <remarks/>
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note;
    
        /// <remarks/>
        public LineItemType LineItem;
    
        /// <remarks/>
        [XmlElement("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem;
    
        /// <remarks/>
        [XmlElement("SellerSubstitutedLineItem")]
        public LineItemType[] SellerSubstitutedLineItem;
    
        /// <remarks/>
        [XmlElement("BuyerProposedSubstituteLineItem")]
        public LineItemType[] BuyerProposedSubstituteLineItem;
    
        /// <remarks/>
        public LineReferenceType CatalogueLineReference;
    
        /// <remarks/>
        public LineReferenceType QuotationLineReference;
    
        /// <remarks/>
        [XmlElement("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference;
    
        /// <remarks/>
        [XmlElement("DocumentReference")]
        public DocumentReferenceType[] DocumentReference;
    }
}