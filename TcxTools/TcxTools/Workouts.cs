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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Workouts_t")]
    public class Workouts
    {
        /// <remarks/>
        public WorkoutFolder Running { get; set; }

        /// <remarks/>
        public WorkoutFolder Biking { get; set; }

        /// <remarks/>
        public WorkoutFolder Other { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
