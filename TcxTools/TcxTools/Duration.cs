using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(UserInitiated))]
    [XmlInclude(typeof(CaloriesBurned))]
    [XmlInclude(typeof(HeartRateBelow))]
    [XmlInclude(typeof(HeartRateAbove))]
    [XmlInclude(typeof(Distance))]
    [XmlInclude(typeof(Time))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Duration_t")]
    public abstract class Duration
    {
    }
}
