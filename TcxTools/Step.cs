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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Step_t")]
    public class Step : AbstractStep
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }

        /// <remarks/>
        public Duration Duration { get; set; }

        /// <remarks/>
        public Intensity Intensity { get; set; }

        /// <remarks/>
        public Target Target { get; set; }
    }
}
