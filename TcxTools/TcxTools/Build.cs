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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Build_t")]
    public class Build
    {
        /// <remarks/>
        public Version Version { get; set; }

        /// <remarks/>
        public BuildType Type { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool TypeSpecified { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Time { get; set; }
        
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Builder { get; set; }
    }
}
