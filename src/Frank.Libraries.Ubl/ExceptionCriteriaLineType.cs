namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ExceptionCriteriaLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ExceptionCriteriaLineType
{

    private IDType idField;

    private NoteType[] noteField;

    private ThresholdValueComparisonCodeType thresholdValueComparisonCodeField;

    private ThresholdQuantityType thresholdQuantityField;

    private ExceptionStatusCodeType exceptionStatusCodeField;

    private CollaborationPriorityCodeType collaborationPriorityCodeField;

    private ExceptionResolutionCodeType exceptionResolutionCodeField;

    private SupplyChainActivityTypeCodeType supplyChainActivityTypeCodeField;

    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;

    private PeriodType effectivePeriodField;

    private ItemType[] supplyItemField;

    private ForecastExceptionCriterionLineType forecastExceptionCriterionLineField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }
        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThresholdValueComparisonCodeType ThresholdValueComparisonCode
    {
        get
        {
            return this.thresholdValueComparisonCodeField;
        }
        set
        {
            this.thresholdValueComparisonCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThresholdQuantityType ThresholdQuantity
    {
        get
        {
            return this.thresholdQuantityField;
        }
        set
        {
            this.thresholdQuantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExceptionStatusCodeType ExceptionStatusCode
    {
        get
        {
            return this.exceptionStatusCodeField;
        }
        set
        {
            this.exceptionStatusCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CollaborationPriorityCodeType CollaborationPriorityCode
    {
        get
        {
            return this.collaborationPriorityCodeField;
        }
        set
        {
            this.collaborationPriorityCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExceptionResolutionCodeType ExceptionResolutionCode
    {
        get
        {
            return this.exceptionResolutionCodeField;
        }
        set
        {
            this.exceptionResolutionCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode
    {
        get
        {
            return this.supplyChainActivityTypeCodeField;
        }
        set
        {
            this.supplyChainActivityTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
    {
        get
        {
            return this.performanceMetricTypeCodeField;
        }
        set
        {
            this.performanceMetricTypeCodeField = value;
        }
    }

    /// <remarks/>
    public PeriodType EffectivePeriod
    {
        get
        {
            return this.effectivePeriodField;
        }
        set
        {
            this.effectivePeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SupplyItem")]
    public ItemType[] SupplyItem
    {
        get
        {
            return this.supplyItemField;
        }
        set
        {
            this.supplyItemField = value;
        }
    }

    /// <remarks/>
    public ForecastExceptionCriterionLineType ForecastExceptionCriterionLine
    {
        get
        {
            return this.forecastExceptionCriterionLineField;
        }
        set
        {
            this.forecastExceptionCriterionLineField = value;
        }
    }
}