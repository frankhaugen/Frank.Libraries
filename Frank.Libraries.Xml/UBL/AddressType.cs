using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Frank.Libraries.Xml.UBL
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.8.3928.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
    public class AddressType
    {

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressTypeCodeType AddressTypeCode;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AddressFormatCodeType AddressFormatCode;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostboxType Postbox;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public FloorType Floor;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RoomType Room;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public StreetNameType StreetName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AdditionalStreetNameType AdditionalStreetName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BlockNameType BlockName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingNameType BuildingName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuildingNumberType BuildingNumber;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InhouseMailType InhouseMail;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DepartmentType Department;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkAttentionType MarkAttention;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public MarkCareType MarkCare;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PlotIdentificationType PlotIdentification;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CitySubdivisionNameType CitySubdivisionName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CityNameType CityName;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PostalZoneType PostalZone;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityType CountrySubentity;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CountrySubentityCodeType CountrySubentityCode;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public RegionType Region;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DistrictType District;

        /// <remarks/>
        [XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimezoneOffsetType TimezoneOffset;

        /// <remarks/>
        [XmlElementAttribute("AddressLine")]
        public AddressLineType[] AddressLine;

        /// <remarks/>
        public CountryType Country;

        /// <remarks/>
        [XmlElementAttribute("LocationCoordinate")]
        public LocationCoordinateType[] LocationCoordinate;
    }
}
