using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(None))]
    [XmlInclude(typeof(Cadence))]
    [XmlInclude(typeof(HeartRate))]
    [XmlInclude(typeof(Speed))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Target_t")]
    public abstract class Target
    {
    }
}
