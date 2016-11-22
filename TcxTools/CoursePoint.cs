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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CoursePoint_t")]
    public class CoursePoint
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        public DateTime Time { get; set; }

        /// <remarks/>
        public Position Position { get; set; }

        /// <remarks/>
        public double AltitudeMeters { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool AltitudeMetersSpecified { get; set; }

        /// <remarks/>
        public CoursePointType PointType { get; set; }

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
