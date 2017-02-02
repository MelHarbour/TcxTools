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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "ActivityLap_t")]
    public class ActivityLap
    {
        /// <remarks/>
        public double TotalTimeSeconds { get; set; }

        /// <remarks/>
        public double DistanceMeters { get; set; }

        /// <remarks/>
        public double MaximumSpeed { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool MaximumSpeedSpecified { get; set; }

        /// <remarks/>
        public ushort Calories { get; set; }

        /// <remarks/>
        public HeartRateInBeatsPerMinute AverageHeartRateBpm { get; set; }

        /// <remarks/>
        public HeartRateInBeatsPerMinute MaximumHeartRateBpm { get; set; }

        /// <remarks/>
        public Intensity Intensity { get; set; }

        /// <remarks/>
        public byte Cadence { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool CadenceSpecified { get; set; }

        /// <remarks/>
        public TriggerMethod TriggerMethod { get; set; }

        /// <remarks/>
        [XmlArrayItem("Trackpoint", typeof(Trackpoint), IsNullable = false)]
        public List<Trackpoint> Track = new List<Trackpoint>();

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public DateTime StartTime { get; set; }

        public ActivityLap()
        {
            Extensions = new Extensions();
        }
    }
}
