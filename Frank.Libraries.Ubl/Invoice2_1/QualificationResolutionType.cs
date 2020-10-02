namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("QualificationResolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class QualificationResolutionType
    {

        private AdmissionCodeType _admissionCodeField;

        private ExclusionReasonType[] _exclusionReasonField;

        private ResolutionType[] _resolutionField;

        private ResolutionDateType _resolutionDateField;

        private ResolutionTimeType _resolutionTimeField;

        private ProcurementProjectLotType _procurementProjectLotField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdmissionCodeType AdmissionCode
        {
            get
            {
                return _admissionCodeField;
            }
            set
            {
                _admissionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExclusionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ExclusionReasonType[] ExclusionReason
        {
            get
            {
                return _exclusionReasonField;
            }
            set
            {
                _exclusionReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResolutionType[] Resolution
        {
            get
            {
                return _resolutionField;
            }
            set
            {
                _resolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResolutionDateType ResolutionDate
        {
            get
            {
                return _resolutionDateField;
            }
            set
            {
                _resolutionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResolutionTimeType ResolutionTime
        {
            get
            {
                return _resolutionTimeField;
            }
            set
            {
                _resolutionTimeField = value;
            }
        }

        /// <remarks/>
        public ProcurementProjectLotType ProcurementProjectLot
        {
            get
            {
                return _procurementProjectLotField;
            }
            set
            {
                _procurementProjectLotField = value;
            }
        }
    }
}