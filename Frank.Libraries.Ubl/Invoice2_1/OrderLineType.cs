namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderLineType
    {

        private SubstitutionStatusCodeType _substitutionStatusCodeField;

        private NoteType[] _noteField;

        private LineItemType _lineItemField;

        private LineItemType[] _sellerProposedSubstituteLineItemField;

        private LineItemType[] _sellerSubstitutedLineItemField;

        private LineItemType[] _buyerProposedSubstituteLineItemField;

        private LineReferenceType _catalogueLineReferenceField;

        private LineReferenceType _quotationLineReferenceField;

        private OrderLineReferenceType[] _orderLineReferenceField;

        private DocumentReferenceType[] _documentReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SubstitutionStatusCodeType SubstitutionStatusCode
        {
            get
            {
                return _substitutionStatusCodeField;
            }
            set
            {
                _substitutionStatusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return _noteField;
            }
            set
            {
                _noteField = value;
            }
        }

        /// <remarks/>
        public LineItemType LineItem
        {
            get
            {
                return _lineItemField;
            }
            set
            {
                _lineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem")]
        public LineItemType[] SellerProposedSubstituteLineItem
        {
            get
            {
                return _sellerProposedSubstituteLineItemField;
            }
            set
            {
                _sellerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem")]
        public LineItemType[] SellerSubstitutedLineItem
        {
            get
            {
                return _sellerSubstitutedLineItemField;
            }
            set
            {
                _sellerSubstitutedLineItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem")]
        public LineItemType[] BuyerProposedSubstituteLineItem
        {
            get
            {
                return _buyerProposedSubstituteLineItemField;
            }
            set
            {
                _buyerProposedSubstituteLineItemField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType CatalogueLineReference
        {
            get
            {
                return _catalogueLineReferenceField;
            }
            set
            {
                _catalogueLineReferenceField = value;
            }
        }

        /// <remarks/>
        public LineReferenceType QuotationLineReference
        {
            get
            {
                return _quotationLineReferenceField;
            }
            set
            {
                _quotationLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLineReference")]
        public OrderLineReferenceType[] OrderLineReference
        {
            get
            {
                return _orderLineReferenceField;
            }
            set
            {
                _orderLineReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
        public DocumentReferenceType[] DocumentReference
        {
            get
            {
                return _documentReferenceField;
            }
            set
            {
                _documentReferenceField = value;
            }
        }
    }
}