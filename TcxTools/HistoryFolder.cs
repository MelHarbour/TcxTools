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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "HistoryFolder_t")]
    public class HistoryFolder
    {
        /// <remarks/>
        [XmlElement("Folder")]
        public HistoryFolder[] Folder { get; set; }
        
        /// <remarks/>
        [XmlElement("ActivityRef")]
        public ActivityReference[] ActivityRef { get; set; }

        /// <remarks/>
        [XmlElement("Week")]
        public Week[] Week { get; set; }

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }

        /// <remarks/>
        [XmlAttribute]
        public string Name { get; set; }
    }
}
