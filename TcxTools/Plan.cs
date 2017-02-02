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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Plan_t")]
    public class Plan
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public TrainingType Type { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public bool IntervalWorkout { get; set; }

        public Plan()
        {
            Extensions = new Extensions();
        }
    }
}
