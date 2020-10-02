namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("BudgetAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class BudgetAccountType
    {

        private IdType _idField;

        private BudgetYearNumericType _budgetYearNumericField;

        private ClassificationSchemeType _requiredClassificationSchemeField;

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
        public BudgetYearNumericType BudgetYearNumeric
        {
            get
            {
                return _budgetYearNumericField;
            }
            set
            {
                _budgetYearNumericField = value;
            }
        }

        /// <remarks/>
        public ClassificationSchemeType RequiredClassificationScheme
        {
            get
            {
                return _requiredClassificationSchemeField;
            }
            set
            {
                _requiredClassificationSchemeField = value;
            }
        }
    }
}