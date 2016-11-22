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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CourseLap_t")]
    public class CourseLap
    {
        /// <remarks/>
        public double TotalTimeSeconds { get; set; }
        
        /// <remarks/>
        public double DistanceMeters { get; set; }

        /// <remarks/>
        public Position BeginPosition { get; set; }

        /// <remarks/>
        public double BeginAltitudeMeters { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool BeginAltitudeMetersSpecified { get; set; }

        /// <remarks/>
        public Position EndPosition { get; set; }

        /// <remarks/>
        public double EndAltitudeMeters { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool EndAltitudeMetersSpecified { get; set; }

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
        public Extensions Extensions { get; set; }
    }
}
