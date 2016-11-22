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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CustomHeartRateZone_t")]
    public class CustomHeartRateZone : Zone
    {
        /// <remarks/>
        public HeartRateValue Low { get; set; }

        /// <remarks/>
        public HeartRateValue High { get; set; }
    }
}
