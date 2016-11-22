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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Version_t")]
    public class Version
    {
        /// <remarks/>
        public ushort VersionMajor { get; set; }

        /// <remarks/>
        public ushort VersionMinor { get; set; }

        /// <remarks/>
        public ushort BuildMajor { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool BuildMajorSpecified { get; set; }

        /// <remarks/>
        public ushort BuildMinor { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool BuildMinorSpecified { get; set; }
    }
}
