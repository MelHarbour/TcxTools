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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Repeat_t")]
    public class Repeat : AbstractStep
    {
        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string Repetitions { get; set; }

        /// <remarks/>
        [XmlElement("Child")]
        public AbstractStep[] Child { get; set; }
    }
}
