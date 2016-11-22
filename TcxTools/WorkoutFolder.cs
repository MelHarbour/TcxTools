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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "WorkoutFolder_t")]
    public class WorkoutFolder
    {
        /// <remarks/>
        [XmlElement("Folder")]
        public WorkoutFolder[] Folder { get; set; }

        /// <remarks/>
        [XmlElement("WorkoutNameRef")]
        public NameKeyReference[] WorkoutNameRef { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
