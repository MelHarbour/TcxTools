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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Course_t")]
    public class Course
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlElement("Lap")]
        public List<CourseLap> Lap = new List<CourseLap>();

        /// <remarks/>
        [XmlArrayItem("Trackpoint", typeof(Trackpoint), IsNullable = false)]
        public List<Trackpoint> Track = new List<Trackpoint>();

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        [XmlElement("CoursePoint")]
        public List<CoursePoint> CoursePoint = new List<CoursePoint>();

        /// <remarks/>
        public AbstractSource Creator { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
