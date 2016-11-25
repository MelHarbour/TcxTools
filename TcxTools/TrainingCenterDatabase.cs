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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "TrainingCenterDatabase_t")]
    [XmlRoot("TrainingCenterDatabase", Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", IsNullable = false)]
    public class TrainingCenterDatabase
    {
        /// <remarks/>
        public Folders Folders { get; set; }

        /// <remarks/>
        public ActivityList Activities { get; set; }

        /// <remarks/>
        [XmlArrayItem("Workout", IsNullable = false)]
        public List<Workout> Workouts = new List<Workout>();

        /// <remarks/>
        [XmlArrayItem("Course", IsNullable = false)]
        public List<Course> Courses = new List<Course>();

        /// <remarks/>
        public AbstractSource Author { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
