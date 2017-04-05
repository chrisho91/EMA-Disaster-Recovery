using System;
using System.Collections.Generic;

namespace EMA.Disaster.Recovery.Models
{
    public class IndividualWorksheet
    {
        public int ID { get; set; }
        public int ContactID {get; set;} 
        public int Code { get; set; }
        public int IndividualWorksheetDamageID { get; set; }
        public string LocationNotes { get; set; }
        public bool PrimaryHome { get; set; }
        public bool Renter { get; set; }
        public string Comments { get; set; }
        public bool FloodInsurance { get; set; }
        public bool BasementWater { get; set; }
        public bool FirstFloorWater { get; set; }
        public int WaterHeight { get; set; }
        public string AdditionalComments { get; set; }
        public string AccessorName { get; set; }
        public string Date { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual IndividualWorksheetDamage IndividualWorksheetDamage { get; set; }
        public virtual ICollection<IndividualSystemDamages> IndividualSystemDamages { get; set; }
    }
}