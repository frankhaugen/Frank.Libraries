namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class OrderLineReferenceType
    {

        private LineIDType lineIDField;

        private SalesOrderLineIDType salesOrderLineIDField;

        private UUIDType uUIDField;

        private LineStatusCodeType lineStatusCodeField;

        private OrderReferenceType orderReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineIDType LineID
        {
            get
            {
                return lineIDField;
            }
            set
            {
                lineIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SalesOrderLineIDType SalesOrderLineID
        {
            get
            {
                return salesOrderLineIDField;
            }
            set
            {
                salesOrderLineIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return uUIDField;
            }
            set
            {
                uUIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return lineStatusCodeField;
            }
            set
            {
                lineStatusCodeField = value;
            }
        }

        /// <remarks/>
        public OrderReferenceType OrderReference
        {
            get
            {
                return orderReferenceField;
            }
            set
            {
                orderReferenceField = value;
            }
        }
    }
}