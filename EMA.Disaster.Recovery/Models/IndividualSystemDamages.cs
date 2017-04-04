using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMA.Disaster.Recovery.Models
{
    public class IndividualSystemDamages
    {
        public int ID { get; set; }
        public int IndividualWorksheetID { get; set; }
        public bool IsMaster { get; set; }
        public string System { get; set; }
        public string PropertyType { get; set; }
        public int PercentReplacementCost { get; set; }

        public virtual IndividualWorksheet IndividualWorksheet { get; set; }
    }
}