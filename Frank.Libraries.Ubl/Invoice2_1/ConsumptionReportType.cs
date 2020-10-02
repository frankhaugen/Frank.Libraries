namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionReportType
    {

        private IDType idField;

        private ConsumptionTypeType consumptionTypeField;

        private ConsumptionTypeCodeType consumptionTypeCodeField;

        private DescriptionType[] descriptionField;

        private TotalConsumedQuantityType totalConsumedQuantityField;

        private BasicConsumedQuantityType basicConsumedQuantityField;

        private ResidentOccupantsNumericType residentOccupantsNumericField;

        private ConsumersEnergyLevelCodeType consumersEnergyLevelCodeField;

        private ConsumersEnergyLevelType consumersEnergyLevelField;

        private ResidenceTypeType residenceTypeField;

        private ResidenceTypeCodeType residenceTypeCodeField;

        private HeatingTypeType heatingTypeField;

        private HeatingTypeCodeType heatingTypeCodeField;

        private PeriodType periodField;

        private DocumentReferenceType guidanceDocumentReferenceField;

        private DocumentReferenceType documentReferenceField;

        private ConsumptionReportReferenceType[] consumptionReportReferenceField;

        private ConsumptionHistoryType[] consumptionHistoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeType ConsumptionType
        {
            get
            {
                return consumptionTypeField;
            }
            set
            {
                consumptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionTypeCodeType ConsumptionTypeCode
        {
            get
            {
                return consumptionTypeCodeField;
            }
            set
            {
                consumptionTypeCodeField = value;
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
        public TotalConsumedQuantityType TotalConsumedQuantity
        {
            get
            {
                return totalConsumedQuantityField;
            }
            set
            {
                totalConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BasicConsumedQuantityType BasicConsumedQuantity
        {
            get
            {
                return basicConsumedQuantityField;
            }
            set
            {
                basicConsumedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidentOccupantsNumericType ResidentOccupantsNumeric
        {
            get
            {
                return residentOccupantsNumericField;
            }
            set
            {
                residentOccupantsNumericField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumersEnergyLevelCodeType ConsumersEnergyLevelCode
        {
            get
            {
                return consumersEnergyLevelCodeField;
            }
            set
            {
                consumersEnergyLevelCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumersEnergyLevelType ConsumersEnergyLevel
        {
            get
            {
                return consumersEnergyLevelField;
            }
            set
            {
                consumersEnergyLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidenceTypeType ResidenceType
        {
            get
            {
                return residenceTypeField;
            }
            set
            {
                residenceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ResidenceTypeCodeType ResidenceTypeCode
        {
            get
            {
                return residenceTypeCodeField;
            }
            set
            {
                residenceTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HeatingTypeType HeatingType
        {
            get
            {
                return heatingTypeField;
            }
            set
            {
                heatingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public HeatingTypeCodeType HeatingTypeCode
        {
            get
            {
                return heatingTypeCodeField;
            }
            set
            {
                heatingTypeCodeField = value;
            }
        }

        /// <remarks/>
        public PeriodType Period
        {
            get
            {
                return periodField;
            }
            set
            {
                periodField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType GuidanceDocumentReference
        {
            get
            {
                return guidanceDocumentReferenceField;
            }
            set
            {
                guidanceDocumentReferenceField = value;
            }
        }

        /// <remarks/>
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return documentReferenceField;
            }
            set
            {
                documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionReportReference")]
        public ConsumptionReportReferenceType[] ConsumptionReportReference
        {
            get
            {
                return consumptionReportReferenceField;
            }
            set
            {
                consumptionReportReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumptionHistory")]
        public ConsumptionHistoryType[] ConsumptionHistory
        {
            get
            {
                return consumptionHistoryField;
            }
            set
            {
                consumptionHistoryField = value;
            }
        }
    }
}