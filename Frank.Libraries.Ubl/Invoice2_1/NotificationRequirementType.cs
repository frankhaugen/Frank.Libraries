namespace Frank.Libraries.Ubl.Invoice2_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [System.Xml.Serialization.XmlRootAttribute("NotificationRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public partial class NotificationRequirementType
    {

        private NotificationTypeCodeType _notificationTypeCodeField;

        private PostEventNotificationDurationMeasureType _postEventNotificationDurationMeasureField;

        private PreEventNotificationDurationMeasureType _preEventNotificationDurationMeasureField;

        private PartyType[] _notifyPartyField;

        private PeriodType[] _notificationPeriodField;

        private LocationType1[] _notificationLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NotificationTypeCodeType NotificationTypeCode
        {
            get
            {
                return _notificationTypeCodeField;
            }
            set
            {
                _notificationTypeCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure
        {
            get
            {
                return _postEventNotificationDurationMeasureField;
            }
            set
            {
                _postEventNotificationDurationMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure
        {
            get
            {
                return _preEventNotificationDurationMeasureField;
            }
            set
            {
                _preEventNotificationDurationMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotifyParty")]
        public PartyType[] NotifyParty
        {
            get
            {
                return _notifyPartyField;
            }
            set
            {
                _notifyPartyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationPeriod")]
        public PeriodType[] NotificationPeriod
        {
            get
            {
                return _notificationPeriodField;
            }
            set
            {
                _notificationPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationLocation")]
        public LocationType1[] NotificationLocation
        {
            get
            {
                return _notificationLocationField;
            }
            set
            {
                _notificationLocationField = value;
            }
        }
    }
}