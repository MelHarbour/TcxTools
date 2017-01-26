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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Trackpoint_t")]
    public class Trackpoint
    {
        /// <remarks/>
        public DateTime Time { get; set; }

        /// <remarks/>
        public Position Position { get; set; }

        /// <remarks/>
        public double AltitudeMeters { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool AltitudeMetersSpecified { get; set; }

        /// <remarks/>
        public double DistanceMeters { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool DistanceMetersSpecified { get; set; }

        /// <remarks/>
        public HeartRateInBeatsPerMinute HeartRateBpm { get; set; }

        /// <remarks/>
        public byte Cadence { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool CadenceSpecified { get; set; }

        /// <remarks/>
        public SensorState SensorState { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool SensorStateSpecified { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        public Trackpoint()
        {
            Extensions = new Extensions();
        }
    }
}
