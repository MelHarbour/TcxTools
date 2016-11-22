using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [Serializable()]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CaloriesBurned_t")]
    public class CaloriesBurned : Duration
    {
        /// <remarks/>
        public ushort Calories { get; set; }
    }
}
