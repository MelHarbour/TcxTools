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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Week_t")]
    public class Week
    {
        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        [XmlAttribute(DataType = "date")]
        public System.DateTime StartDay { get; set; }
    }
}
