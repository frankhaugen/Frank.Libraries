namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemIdentificationType
    {

        private IdType _idField;

        private ExtendedIdType _extendedIdField;

        private BarcodeSymbologyIdType _barcodeSymbologyIdField;

        private PhysicalAttributeType[] _physicalAttributeField;

        private DimensionType[] _measurementDimensionField;

        private PartyType _issuerPartyField;

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
        public ExtendedIdType ExtendedId
        {
            get
            {
                return _extendedIdField;
            }
            set
            {
                _extendedIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BarcodeSymbologyIdType BarcodeSymbologyId
        {
            get
            {
                return _barcodeSymbologyIdField;
            }
            set
            {
                _barcodeSymbologyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAttribute")]
        public PhysicalAttributeType[] PhysicalAttribute
        {
            get
            {
                return _physicalAttributeField;
            }
            set
            {
                _physicalAttributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
        public DimensionType[] MeasurementDimension
        {
            get
            {
                return _measurementDimensionField;
            }
            set
            {
                _measurementDimensionField = value;
            }
        }

        /// <remarks/>
        public PartyType IssuerParty
        {
            get
            {
                return _issuerPartyField;
            }
            set
            {
                _issuerPartyField = value;
            }
        }
    }
}