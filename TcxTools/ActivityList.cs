﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TcxTools
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "ActivityList_t")]
    public class ActivityList
    {
        /// <remarks/>
        [XmlElement("Activity")]
        public List<Activity> Activity = new List<Activity>();

        /// <remarks/>
        [XmlElement("MultiSportSession")]
        public List<MultiSportSession> MultiSportSession = new List<MultiSportSession>();
    }
}
