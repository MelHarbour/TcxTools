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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Courses_t")]
    public class Courses
    {
        /// <remarks/>
        public CourseFolder CourseFolder { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
