using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(Application))]
    [XmlInclude(typeof(Device))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "AbstractSource_t")]
    public abstract class AbstractSource
    {
        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string Name { get; set; }
    }
}
