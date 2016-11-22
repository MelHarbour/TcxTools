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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CourseFolder_t")]
    public class CourseFolder
    {
        /// <remarks/>
        [XmlElement("Folder")]
        public CourseFolder[] Folder { get; set; }

        /// <remarks/>
        [XmlElement("CourseNameRef")]
        public NameKeyReference[] CourseNameRef { get; set; }

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
