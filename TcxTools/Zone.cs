using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(CustomHeartRateZone))]
    [XmlInclude(typeof(PredefinedHeartRateZone))]
    [XmlInclude(typeof(CustomSpeedZone))]
    [XmlInclude(typeof(PredefinedSpeedZone))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Zone_t")]
    public abstract class Zone
    {
    }
}
