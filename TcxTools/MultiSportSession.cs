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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "MultiSportSession_t")]
    public class MultiSportSession
    {
        /// <remarks/>
        public DateTime Id { get; set; }

        /// <remarks/>
        public FirstSport FirstSport { get; set; }

        /// <remarks/>
        [XmlElement("NextSport")]
        public List<NextSport> NextSport = new List<NextSport>();

        /// <remarks/>
        public string Notes { get; set; }
    }
}
