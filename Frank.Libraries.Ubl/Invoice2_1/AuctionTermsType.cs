namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AuctionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class AuctionTermsType
    {

        private AuctionConstraintIndicatorType _auctionConstraintIndicatorField;

        private JustificationDescriptionType[] _justificationDescriptionField;

        private DescriptionType[] _descriptionField;

        private ProcessDescriptionType[] _processDescriptionField;

        private ConditionsDescriptionType[] _conditionsDescriptionField;

        private ElectronicDeviceDescriptionType[] _electronicDeviceDescriptionField;

        private AuctionUriType _auctionUriField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AuctionConstraintIndicatorType AuctionConstraintIndicator
        {
            get
            {
                return _auctionConstraintIndicatorField;
            }
            set
            {
                _auctionConstraintIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JustificationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public JustificationDescriptionType[] JustificationDescription
        {
            get
            {
                return _justificationDescriptionField;
            }
            set
            {
                _justificationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return _descriptionField;
            }
            set
            {
                _descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProcessDescriptionType[] ProcessDescription
        {
            get
            {
                return _processDescriptionField;
            }
            set
            {
                _processDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConditionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionsDescriptionType[] ConditionsDescription
        {
            get
            {
                return _conditionsDescriptionField;
            }
            set
            {
                _conditionsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicDeviceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ElectronicDeviceDescriptionType[] ElectronicDeviceDescription
        {
            get
            {
                return _electronicDeviceDescriptionField;
            }
            set
            {
                _electronicDeviceDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AuctionUriType AuctionUri
        {
            get
            {
                return _auctionUriField;
            }
            set
            {
                _auctionUriField = value;
            }
        }
    }
}