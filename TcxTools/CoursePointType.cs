using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CoursePointType_t")]
    public enum CoursePointType
    {

        /// <remarks/>
        Generic,

        /// <remarks/>
        Summit,

        /// <remarks/>
        Valley,

        /// <remarks/>
        Water,

        /// <remarks/>
        Food,

        /// <remarks/>
        Danger,

        /// <remarks/>
        Left,

        /// <remarks/>
        Right,

        /// <remarks/>
        Straight,

        /// <remarks/>
        [XmlEnum("First Aid")]
        FirstAid,

        /// <remarks/>
        [XmlEnum("4th Category")]
        Item4thCategory,

        /// <remarks/>
        [XmlEnum("3rd Category")]
        Item3rdCategory,

        /// <remarks/>
        [XmlEnum("2nd Category")]
        Item2ndCategory,

        /// <remarks/>
        [XmlEnum("1st Category")]
        Item1stCategory,

        /// <remarks/>
        [XmlEnum("Hors Category")]
        HorsCategory,

        /// <remarks/>
        Sprint,
    }
}
