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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Activity_t")]
    public class Activity
    {
        /// <remarks/>
        public DateTime Id { get; set; }

        /// <remarks/>
        [XmlElement("Lap")]
        public List<ActivityLap> Lap = new List<ActivityLap>();

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Training Training { get; set; }

        /// <remarks/>
        public AbstractSource Creator { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public Sport Sport { get; set; }
    }
}
