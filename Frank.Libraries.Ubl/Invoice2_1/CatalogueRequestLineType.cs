namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CatalogueRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class CatalogueRequestLineType
    {

        private IdType _idField;

        private ContractSubdivisionType _contractSubdivisionField;

        private NoteType[] _noteField;

        private PeriodType _lineValidityPeriodField;

        private ItemLocationQuantityType[] _requiredItemLocationQuantityField;

        private ItemType _itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdType Id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ContractSubdivisionType ContractSubdivision
        {
            get
            {
                return _contractSubdivisionField;
            }
            set
            {
                _contractSubdivisionField = value;
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
        public PeriodType LineValidityPeriod
        {
            get
            {
                return _lineValidityPeriodField;
            }
            set
            {
                _lineValidityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
        public ItemLocationQuantityType[] RequiredItemLocationQuantity
        {
            get
            {
                return _requiredItemLocationQuantityField;
            }
            set
            {
                _requiredItemLocationQuantityField = value;
            }
        }

        /// <remarks/>
        public ItemType Item
        {
            get
            {
                return _itemField;
            }
            set
            {
                _itemField = value;
            }
        }
    }
}