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
        public List<CourseFolder> Folder = new List<CourseFolder>();

        /// <remarks/>
        [XmlElement("CourseNameRef")]
        public List<NameKeyReference> CourseNameRef = new List<NameKeyReference>();

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Name { get; set; }

        public CourseFolder()
        {
            Extensions = new Extensions();
        }
    }
}
