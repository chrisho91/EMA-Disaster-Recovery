﻿
namespace EMA.Disaster.Recovery.Models
{
    public class IndividualSystemDamages
    {
        public int ID { get; set; }
        public bool IsMaster { get; set; }
        public string System { get; set; }
        public string PropertyType { get; set; }
        public int PercentReplacementCost { get; set; }

        public virtual IndividualWorksheet IndividualWorksheet { get; set; }
    }
}