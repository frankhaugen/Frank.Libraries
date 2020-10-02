namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("EnergyTaxReport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class EnergyTaxReportType
    {

        private TaxEnergyAmountType taxEnergyAmountField;

        private TaxEnergyOnAccountAmountType taxEnergyOnAccountAmountField;

        private TaxEnergyBalanceAmountType taxEnergyBalanceAmountField;

        private TaxSchemeType taxSchemeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyAmountType TaxEnergyAmount
        {
            get
            {
                return taxEnergyAmountField;
            }
            set
            {
                taxEnergyAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyOnAccountAmountType TaxEnergyOnAccountAmount
        {
            get
            {
                return taxEnergyOnAccountAmountField;
            }
            set
            {
                taxEnergyOnAccountAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxEnergyBalanceAmountType TaxEnergyBalanceAmount
        {
            get
            {
                return taxEnergyBalanceAmountField;
            }
            set
            {
                taxEnergyBalanceAmountField = value;
            }
        }

        /// <remarks/>
        public TaxSchemeType TaxScheme
        {
            get
            {
                return taxSchemeField;
            }
            set
            {
                taxSchemeField = value;
            }
        }
    }
}