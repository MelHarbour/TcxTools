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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "NextSport_t")]
    public class NextSport
    {
        /// <remarks/>
        public ActivityLap Transition { get; set; }

        /// <remarks/>
        public Activity Activity { get; set; }
    }
}
