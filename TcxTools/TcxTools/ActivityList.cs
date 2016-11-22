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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "ActivityList_t")]
    public class ActivityList
    {
        /// <remarks/>
        [XmlElement("Activity")]
        public Activity[] Activity { get; set; }

        /// <remarks/>
        [XmlElement("MultiSportSession")]
        public MultiSportSession[] MultiSportSession { get; set; }
    }
}
