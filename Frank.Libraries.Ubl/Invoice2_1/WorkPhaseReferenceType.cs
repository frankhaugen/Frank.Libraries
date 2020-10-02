namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("WorkPhaseReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class WorkPhaseReferenceType
    {

        private IdType _idField;

        private WorkPhaseCodeType _workPhaseCodeField;

        private WorkPhaseType[] _workPhaseField;

        private ProgressPercentType _progressPercentField;

        private StartDateType _startDateField;

        private EndDateType _endDateField;

        private DocumentReferenceType[] _workOrderDocumentReferenceField;

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
        public WorkPhaseCodeType WorkPhaseCode
        {
            get
            {
                return _workPhaseCodeField;
            }
            set
            {
                _workPhaseCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkPhase", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public WorkPhaseType[] WorkPhase
        {
            get
            {
                return _workPhaseField;
            }
            set
            {
                _workPhaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProgressPercentType ProgressPercent
        {
            get
            {
                return _progressPercentField;
            }
            set
            {
                _progressPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StartDateType StartDate
        {
            get
            {
                return _startDateField;
            }
            set
            {
                _startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public EndDateType EndDate
        {
            get
            {
                return _endDateField;
            }
            set
            {
                _endDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkOrderDocumentReference")]
        public DocumentReferenceType[] WorkOrderDocumentReference
        {
            get
            {
                return _workOrderDocumentReferenceField;
            }
            set
            {
                _workOrderDocumentReferenceField = value;
            }
        }
    }
}