namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class LocationCoordinateType
    {

        private CoordinateSystemCodeType _coordinateSystemCodeField;

        private LatitudeDegreesMeasureType _latitudeDegreesMeasureField;

        private LatitudeMinutesMeasureType _latitudeMinutesMeasureField;

        private LatitudeDirectionCodeType _latitudeDirectionCodeField;

        private LongitudeDegreesMeasureType _longitudeDegreesMeasureField;

        private LongitudeMinutesMeasureType _longitudeMinutesMeasureField;

        private LongitudeDirectionCodeType _longitudeDirectionCodeField;

        private AltitudeMeasureType _altitudeMeasureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CoordinateSystemCodeType CoordinateSystemCode
        {
            get
            {
                return _coordinateSystemCodeField;
            }
            set
            {
                _coordinateSystemCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeDegreesMeasureType LatitudeDegreesMeasure
        {
            get
            {
                return _latitudeDegreesMeasureField;
            }
            set
            {
                _latitudeDegreesMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeMinutesMeasureType LatitudeMinutesMeasure
        {
            get
            {
                return _latitudeMinutesMeasureField;
            }
            set
            {
                _latitudeMinutesMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LatitudeDirectionCodeType LatitudeDirectionCode
        {
            get
            {
                return _latitudeDirectionCodeField;
            }
            set
            {
                _latitudeDirectionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeDegreesMeasureType LongitudeDegreesMeasure
        {
            get
            {
                return _longitudeDegreesMeasureField;
            }
            set
            {
                _longitudeDegreesMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeMinutesMeasureType LongitudeMinutesMeasure
        {
            get
            {
                return _longitudeMinutesMeasureField;
            }
            set
            {
                _longitudeMinutesMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LongitudeDirectionCodeType LongitudeDirectionCode
        {
            get
            {
                return _longitudeDirectionCodeField;
            }
            set
            {
                _longitudeDirectionCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AltitudeMeasureType AltitudeMeasure
        {
            get
            {
                return _altitudeMeasureField;
            }
            set
            {
                _altitudeMeasureField = value;
            }
        }
    }
}