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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Workout_t")]
    public class Workout
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlElement("Step")]
        public List<AbstractStep> Step = new List<AbstractStep>();

        /// <remarks/>
        [XmlElement("ScheduledOn", DataType = "date")]
        public List<DateTime> ScheduledOn = new List<DateTime>();

        /// <remarks/>
        public string Notes { get; set; }
        
        /// <remarks/>
        public AbstractSource Creator { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public Sport Sport { get; set; }
    }
}