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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "PredefinedSpeedZone_t")]
    public class PredefinedSpeedZone : Zone
    {
        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string Number { get; set; }
    }
}
