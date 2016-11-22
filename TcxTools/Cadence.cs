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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Cadence_t")]
    public class Cadence : Target
    {
        /// <remarks/>
        public double Low { get; set; }

        /// <remarks/>
        public double High { get; set; }
    }
}
