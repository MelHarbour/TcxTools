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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Device_t")]
    public class Device : AbstractSource
    {
        /// <remarks/>
        public uint UnitId { get; set; }

        /// <remarks/>
        public ushort ProductID { get; set; }

        /// <remarks/>
        public Version Version { get; set; }
    }
}
