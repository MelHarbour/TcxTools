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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Folders_t")]
    public class Folders
    {
        /// <remarks/>
        public History History { get; set; }
        
        /// <remarks/>
        public Workouts Workouts { get; set; }

        /// <remarks/>
        public Courses Courses { get; set; }

        public Folders()
        {
            History = new History();
            Workouts = new Workouts();
            Courses = new Courses();
        }
    }
}
