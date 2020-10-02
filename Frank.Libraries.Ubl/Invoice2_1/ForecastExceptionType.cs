namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("ForecastException", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ForecastExceptionType
    {

        private ForecastPurposeCodeType _forecastPurposeCodeField;

        private ForecastTypeCodeType _forecastTypeCodeField;

        private IssueDateType _issueDateField;

        private IssueTimeType _issueTimeField;

        private DataSourceCodeType _dataSourceCodeField;

        private ComparisonDataCodeType _comparisonDataCodeField;

        private ComparisonForecastIssueTimeType _comparisonForecastIssueTimeField;

        private ComparisonForecastIssueDateType _comparisonForecastIssueDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastPurposeCodeType ForecastPurposeCode
        {
            get
            {
                return _forecastPurposeCodeField;
            }
            set
            {
                _forecastPurposeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ForecastTypeCodeType ForecastTypeCode
        {
            get
            {
                return _forecastTypeCodeField;
            }
            set
            {
                _forecastTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return _issueDateField;
            }
            set
            {
                _issueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return _issueTimeField;
            }
            set
            {
                _issueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DataSourceCodeType DataSourceCode
        {
            get
            {
                return _dataSourceCodeField;
            }
            set
            {
                _dataSourceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonDataCodeType ComparisonDataCode
        {
            get
            {
                return _comparisonDataCodeField;
            }
            set
            {
                _comparisonDataCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonForecastIssueTimeType ComparisonForecastIssueTime
        {
            get
            {
                return _comparisonForecastIssueTimeField;
            }
            set
            {
                _comparisonForecastIssueTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ComparisonForecastIssueDateType ComparisonForecastIssueDate
        {
            get
            {
                return _comparisonForecastIssueDateField;
            }
            set
            {
                _comparisonForecastIssueDateField = value;
            }
        }
    }
}