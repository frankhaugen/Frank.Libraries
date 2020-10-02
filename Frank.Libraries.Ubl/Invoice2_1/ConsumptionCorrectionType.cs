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

        private CorrectionTypeType _correctionTypeField;

        private CorrectionTypeCodeType _correctionTypeCodeField;

        private MeterNumberType _meterNumberField;

        private GasPressureQuantityType _gasPressureQuantityField;

        private ActualTemperatureReductionQuantityType _actualTemperatureReductionQuantityField;

        private NormalTemperatureReductionQuantityType _normalTemperatureReductionQuantityField;

        private DifferenceTemperatureReductionQuantityType _differenceTemperatureReductionQuantityField;

        private DescriptionType[] _descriptionField;

        private CorrectionUnitAmountType _correctionUnitAmountField;

        private ConsumptionEnergyQuantityType _consumptionEnergyQuantityField;

        private ConsumptionWaterQuantityType _consumptionWaterQuantityField;

        private CorrectionAmountType _correctionAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionTypeType CorrectionType
        {
            get
            {
                return _correctionTypeField;
            }
            set
            {
                _correctionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionTypeCodeType CorrectionTypeCode
        {
            get
            {
                return _correctionTypeCodeField;
            }
            set
            {
                _correctionTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MeterNumberType MeterNumber
        {
            get
            {
                return _meterNumberField;
            }
            set
            {
                _meterNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public GasPressureQuantityType GasPressureQuantity
        {
            get
            {
                return _gasPressureQuantityField;
            }
            set
            {
                _gasPressureQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ActualTemperatureReductionQuantityType ActualTemperatureReductionQuantity
        {
            get
            {
                return _actualTemperatureReductionQuantityField;
            }
            set
            {
                _actualTemperatureReductionQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NormalTemperatureReductionQuantityType NormalTemperatureReductionQuantity
        {
            get
            {
                return _normalTemperatureReductionQuantityField;
            }
            set
            {
                _normalTemperatureReductionQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DifferenceTemperatureReductionQuantityType DifferenceTemperatureReductionQuantity
        {
            get
            {
                return _differenceTemperatureReductionQuantityField;
            }
            set
            {
                _differenceTemperatureReductionQuantityField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionUnitAmountType CorrectionUnitAmount
        {
            get
            {
                return _correctionUnitAmountField;
            }
            set
            {
                _correctionUnitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionEnergyQuantityType ConsumptionEnergyQuantity
        {
            get
            {
                return _consumptionEnergyQuantityField;
            }
            set
            {
                _consumptionEnergyQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ConsumptionWaterQuantityType ConsumptionWaterQuantity
        {
            get
            {
                return _consumptionWaterQuantityField;
            }
            set
            {
                _consumptionWaterQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CorrectionAmountType CorrectionAmount
        {
            get
            {
                return _correctionAmountField;
            }
            set
            {
                _correctionAmountField = value;
            }
        }
    }
}