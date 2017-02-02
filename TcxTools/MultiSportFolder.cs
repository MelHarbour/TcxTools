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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "MultiSportFolder_t")]
    public class MultiSportFolder
    {
        /// <remarks/>
        [XmlElement("Folder")]
        public List<MultiSportFolder> Folder = new List<MultiSportFolder>();

        /// <remarks/>
        [XmlElement("MultisportActivityRef")]
        public List<ActivityReference> MultisportActivityRef = new List<ActivityReference>();

        /// <remarks/>
        [XmlElement("Week")]
        public List<Week> Week = new List<Week>();

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute()]
        public string Name { get; set; }

        public MultiSportFolder()
        {
            Extensions = new Extensions();
        }
    }
}
