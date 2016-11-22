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
    [XmlType(Namespace = "http://www.garmin.com/xmlschemas/TrainingCenterDatabase/v2", TypeName = "CustomSpeedZone_t")]
    public class CustomSpeedZone : Zone
    {
        /// <remarks/>
        public SpeedType ViewAs { get; set; }

        /// <remarks/>
        public double LowInMetersPerSecond { get; set; }

        /// <remarks/>
        public double HighInMetersPerSecond { get; set; }
    }
}
