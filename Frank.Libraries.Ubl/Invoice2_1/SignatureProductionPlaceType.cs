namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignatureProductionPlaceType
    {

        private string _cityField;

        private string _stateOrProvinceField;

        private string _postalCodeField;

        private string _countryNameField;

        /// <remarks/>
        public string City
        {
            get
            {
                return _cityField;
            }
            set
            {
                _cityField = value;
            }
        }

        /// <remarks/>
        public string StateOrProvince
        {
            get
            {
                return _stateOrProvinceField;
            }
            set
            {
                _stateOrProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return _postalCodeField;
            }
            set
            {
                _postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryName
        {
            get
            {
                return _countryNameField;
            }
            set
            {
                _countryNameField = value;
            }
        }
    }
}