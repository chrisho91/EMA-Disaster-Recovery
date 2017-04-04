using System;

namespace EMA.Disaster.Recovery.Models
{
    public class SBAEconInjurySurvey
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public DateTime DisasterDate { get; set; }
        public string DisasterType { get; set; }
        public bool MultipleLocations { get; set; }
        public DateTime FiscalYearStart { get; set; }
        public DateTime FiscalYearEnd { get; set; }
        public int LastGrossSales { get; set; }
        public int YTDGrossSales { get; set; }
        public int GrossSalesFromDD { get; set; }
        public int ProjectedGrossSales { get; set; }
        public int EstInsuranceRecovery { get; set; }
        public DateTime EstNormalDate { get; set; }
        public string AdditionalComments { get; set; }
        public DateTime PrevPeriodStart { get; set; }
        public DateTime PrevPeriodEnd { get; set; }
    }
}