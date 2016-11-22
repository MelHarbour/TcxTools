using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(HeartRateAsPercentOfMax))]
    [XmlInclude(typeof(HeartRateInBeatsPerMinute))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "HeartRateValue_t")]
    public abstract class HeartRateValue
    {
    }
}
