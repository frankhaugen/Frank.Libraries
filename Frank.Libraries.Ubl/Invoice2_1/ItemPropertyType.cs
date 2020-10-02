namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("AdditionalItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class ItemPropertyType
    {

        private IdType _idField;

        private NameType1 _nameField;

        private NameCodeType _nameCodeField;

        private TestMethodType _testMethodField;

        private ValueType _valueField;

        private ValueQuantityType _valueQuantityField;

        private ValueQualifierType[] _valueQualifierField;

        private ImportanceCodeType _importanceCodeField;

        private ListValueType[] _listValueField;

        private PeriodType _usabilityPeriodField;

        private ItemPropertyGroupType[] _itemPropertyGroupField;

        private DimensionType _rangeDimensionField;

        private ItemPropertyRangeType _itemPropertyRangeField;

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
        public NameType1 Name
        {
            get
            {
                return _nameField;
            }
            set
            {
                _nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameCodeType NameCode
        {
            get
            {
                return _nameCodeField;
            }
            set
            {
                _nameCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TestMethodType TestMethod
        {
            get
            {
                return _testMethodField;
            }
            set
            {
                _testMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueType Value
        {
            get
            {
                return _valueField;
            }
            set
            {
                _valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueQuantityType ValueQuantity
        {
            get
            {
                return _valueQuantityField;
            }
            set
            {
                _valueQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueQualifierType[] ValueQualifier
        {
            get
            {
                return _valueQualifierField;
            }
            set
            {
                _valueQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ImportanceCodeType ImportanceCode
        {
            get
            {
                return _importanceCodeField;
            }
            set
            {
                _importanceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ListValueType[] ListValue
        {
            get
            {
                return _listValueField;
            }
            set
            {
                _listValueField = value;
            }
        }

        /// <remarks/>
        public PeriodType UsabilityPeriod
        {
            get
            {
                return _usabilityPeriodField;
            }
            set
            {
                _usabilityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemPropertyGroup")]
        public ItemPropertyGroupType[] ItemPropertyGroup
        {
            get
            {
                return _itemPropertyGroupField;
            }
            set
            {
                _itemPropertyGroupField = value;
            }
        }

        /// <remarks/>
        public DimensionType RangeDimension
        {
            get
            {
                return _rangeDimensionField;
            }
            set
            {
                _rangeDimensionField = value;
            }
        }

        /// <remarks/>
        public ItemPropertyRangeType ItemPropertyRange
        {
            get
            {
                return _itemPropertyRangeField;
            }
            set
            {
                _itemPropertyRangeField = value;
            }
        }
    }
}