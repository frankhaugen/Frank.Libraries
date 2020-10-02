namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class StatusType
    {

        private ConditionCodeType conditionCodeField;

        private ReferenceDateType referenceDateField;

        private ReferenceTimeType referenceTimeField;

        private DescriptionType[] descriptionField;

        private StatusReasonCodeType statusReasonCodeField;

        private StatusReasonType[] statusReasonField;

        private SequenceIDType sequenceIDField;

        private TextType2[] textField;

        private IndicationIndicatorType indicationIndicatorField;

        private PercentType1 percentField;

        private ReliabilityPercentType reliabilityPercentField;

        private ConditionType1[] conditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConditionCodeType ConditionCode
        {
            get
            {
                return conditionCodeField;
            }
            set
            {
                conditionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceDateType ReferenceDate
        {
            get
            {
                return referenceDateField;
            }
            set
            {
                referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReferenceTimeType ReferenceTime
        {
            get
            {
                return referenceTimeField;
            }
            set
            {
                referenceTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DescriptionType[] Description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StatusReasonCodeType StatusReasonCode
        {
            get
            {
                return statusReasonCodeField;
            }
            set
            {
                statusReasonCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StatusReasonType[] StatusReason
        {
            get
            {
                return statusReasonField;
            }
            set
            {
                statusReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public SequenceIDType SequenceID
        {
            get
            {
                return sequenceIDField;
            }
            set
            {
                sequenceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType2[] Text
        {
            get
            {
                return textField;
            }
            set
            {
                textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicationIndicatorType IndicationIndicator
        {
            get
            {
                return indicationIndicatorField;
            }
            set
            {
                indicationIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PercentType1 Percent
        {
            get
            {
                return percentField;
            }
            set
            {
                percentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ReliabilityPercentType ReliabilityPercent
        {
            get
            {
                return reliabilityPercentField;
            }
            set
            {
                reliabilityPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Condition")]
        public ConditionType1[] Condition
        {
            get
            {
                return conditionField;
            }
            set
            {
                conditionField = value;
            }
        }
    }
}