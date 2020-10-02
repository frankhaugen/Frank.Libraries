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

        private IDType idField;

        private NameType1 nameField;

        private NameCodeType nameCodeField;

        private TestMethodType testMethodField;

        private ValueType valueField;

        private ValueQuantityType valueQuantityField;

        private ValueQualifierType[] valueQualifierField;

        private ImportanceCodeType importanceCodeField;

        private ListValueType[] listValueField;

        private PeriodType usabilityPeriodField;

        private ItemPropertyGroupType[] itemPropertyGroupField;

        private DimensionType rangeDimensionField;

        private ItemPropertyRangeType itemPropertyRangeField;

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
        public NameType1 Name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameCodeType NameCode
        {
            get
            {
                return nameCodeField;
            }
            set
            {
                nameCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TestMethodType TestMethod
        {
            get
            {
                return testMethodField;
            }
            set
            {
                testMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueType Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueQuantityType ValueQuantity
        {
            get
            {
                return valueQuantityField;
            }
            set
            {
                valueQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueQualifier", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ValueQualifierType[] ValueQualifier
        {
            get
            {
                return valueQualifierField;
            }
            set
            {
                valueQualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ImportanceCodeType ImportanceCode
        {
            get
            {
                return importanceCodeField;
            }
            set
            {
                importanceCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListValue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ListValueType[] ListValue
        {
            get
            {
                return listValueField;
            }
            set
            {
                listValueField = value;
            }
        }

        /// <remarks/>
        public PeriodType UsabilityPeriod
        {
            get
            {
                return usabilityPeriodField;
            }
            set
            {
                usabilityPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemPropertyGroup")]
        public ItemPropertyGroupType[] ItemPropertyGroup
        {
            get
            {
                return itemPropertyGroupField;
            }
            set
            {
                itemPropertyGroupField = value;
            }
        }

        /// <remarks/>
        public DimensionType RangeDimension
        {
            get
            {
                return rangeDimensionField;
            }
            set
            {
                rangeDimensionField = value;
            }
        }

        /// <remarks/>
        public ItemPropertyRangeType ItemPropertyRange
        {
            get
            {
                return itemPropertyRangeField;
            }
            set
            {
                itemPropertyRangeField = value;
            }
        }
    }
}