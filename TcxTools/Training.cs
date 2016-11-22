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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Training_t")]
    public class Training
    {
        /// <remarks/>
        public QuickWorkout QuickWorkoutResults { get; set; }

        /// <remarks/>
        public Plan Plan { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool VirtualPartner { get; set; }
    }
}
