namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ConsumptionCorrection", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ConsumptionCorrectionType
    {

        private CorrectionTypeType correctionTypeField;

        private CorrectionTypeCodeType correctionTypeCodeField;

        private MeterNumberType meterNumberField;

        private GasPressureQuantityType gasPressureQuantityField;

        private ActualTemperatureReductionQuantityType actualTemperatureReductionQuantityField;

        private NormalTemperatureReductionQuantityType normalTemperatureReductionQuantityField;

        private DifferenceTemperatureReductionQuantityType differenceTemperatureReductionQuantityField;

        private DescriptionType[] descriptionField;

        private CorrectionUnitAmountType correctionUnitAmountField;

        private ConsumptionEnergyQuantityType consumptionEnergyQuantityField;

        private ConsumptionWaterQuantityType consumptionWaterQuantityField;

        private CorrectionAmountType correctionAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionTypeType CorrectionType
        {
            get
            {
                return correctionTypeField;
            }
            set
            {
                correctionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionTypeCodeType CorrectionTypeCode
        {
            get
            {
                return correctionTypeCodeField;
            }
            set
            {
                correctionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNumberType MeterNumber
        {
            get
            {
                return meterNumberField;
            }
            set
            {
                meterNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GasPressureQuantityType GasPressureQuantity
        {
            get
            {
                return gasPressureQuantityField;
            }
            set
            {
                gasPressureQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualTemperatureReductionQuantityType ActualTemperatureReductionQuantity
        {
            get
            {
                return actualTemperatureReductionQuantityField;
            }
            set
            {
                actualTemperatureReductionQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NormalTemperatureReductionQuantityType NormalTemperatureReductionQuantity
        {
            get
            {
                return normalTemperatureReductionQuantityField;
            }
            set
            {
                normalTemperatureReductionQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DifferenceTemperatureReductionQuantityType DifferenceTemperatureReductionQuantity
        {
            get
            {
                return differenceTemperatureReductionQuantityField;
            }
            set
            {
                differenceTemperatureReductionQuantityField = value;
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
        public CorrectionUnitAmountType CorrectionUnitAmount
        {
            get
            {
                return correctionUnitAmountField;
            }
            set
            {
                correctionUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionEnergyQuantityType ConsumptionEnergyQuantity
        {
            get
            {
                return consumptionEnergyQuantityField;
            }
            set
            {
                consumptionEnergyQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionWaterQuantityType ConsumptionWaterQuantity
        {
            get
            {
                return consumptionWaterQuantityField;
            }
            set
            {
                consumptionWaterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionAmountType CorrectionAmount
        {
            get
            {
                return correctionAmountField;
            }
            set
            {
                correctionAmountField = value;
            }
        }
    }
}