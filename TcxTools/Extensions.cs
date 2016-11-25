using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Extensions_t")]
    public class Extensions
    {
        /// <remarks/>
        [XmlAnyElement]
        public List<XmlElement> Any = new List<XmlElement>();
    }
}
