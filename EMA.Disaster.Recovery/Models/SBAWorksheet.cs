
using System;

namespace EMA.Disaster.Recovery.Models
{
    public class SBAWorksheet
    {
        public int ID { get; set; }
        public string PropertyOwner { get; set; }
        public DateTime DisasterDate { get; set; }
        public string DisasterType { get; set; }
        public string ApplicantType { get; set; }
        public string Comments { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual SBALocationType LocationType { get; set; }
        public virtual SBAEconInjurySurvey SBAEconInjurySurvey { get; set; }
        public virtual SBAPropertyMarketValue SBAPropertyMarketValue { get; set; }
    }
}