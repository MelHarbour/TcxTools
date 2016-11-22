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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "Application_t")]
    public class Application : AbstractSource
    {
        /// <remarks/>
        public Build Build { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string LangID { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "token")]
        public string PartNumber { get; set; }
    }
}
