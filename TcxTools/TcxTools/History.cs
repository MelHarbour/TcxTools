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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "History_t")]
    public class History
    {
        /// <remarks/>
        public HistoryFolder Running { get; set; }

        /// <remarks/>
        public HistoryFolder Biking { get; set; }

        /// <remarks/>
        public HistoryFolder Other { get; set; }
        
        /// <remarks/>
        public MultiSportFolder MultiSport { get; set; }

        /// <remarks/>
        public Extensions Extensions { get; set; }
    }
}
