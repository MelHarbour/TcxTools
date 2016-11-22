using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [XmlInclude(typeof(Step))]
    [XmlInclude(typeof(Repeat))]
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "AbstractStep_t")]
    public abstract class AbstractStep
    {
        /// <remarks/>
        [XmlElement(DataType = "positiveInteger")]
        public string StepId { get; set; }
    }
}
