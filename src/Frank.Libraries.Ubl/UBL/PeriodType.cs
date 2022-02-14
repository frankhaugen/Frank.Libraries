namespace Frank.Libraries.Ubl;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PeriodType
{

    private StartDateType startDateField;

    private StartTimeType startTimeField;

    private EndDateType endDateField;

    private EndTimeType endTimeField;

    private DurationMeasureType durationMeasureField;

    private DescriptionCodeType[] descriptionCodeField;

    private DescriptionType[] descriptionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StartDateType StartDate
    {
        get
        {
            return this.startDateField;
        }
        set
        {
            this.startDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public StartTimeType StartTime
    {
        get
        {
            return this.startTimeField;
        }
        set
        {
            this.startTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EndDateType EndDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EndTimeType EndTime
    {
        get
        {
            return this.endTimeField;
        }
        set
        {
            this.endTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DurationMeasureType DurationMeasure
    {
        get
        {
            return this.durationMeasureField;
        }
        set
        {
            this.durationMeasureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionCodeType[] DescriptionCode
    {
        get
        {
            return this.descriptionCodeField;
        }
        set
        {
            this.descriptionCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}