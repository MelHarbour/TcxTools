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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "QuickWorkout_t")]
    public class QuickWorkout
    {
        /// <remarks/>
        public double TotalTimeSeconds { get; set; }

        /// <remarks/>
        public double DistanceMeters { get; set; }
    }
}
