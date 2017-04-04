
namespace EMA.Disaster.Recovery.Models
{
    public class SBAPropertyMarketValue
    {
        public int ID { get; set; }
        public int SBAWorksheetID { get; set; }
        public string PropertySection { get; set; }
        public int DisasterLoss { get; set; }
        public int InsuranceAmount { get; set; }

        public virtual SBAWorksheet SBAWorksheet { get; set; }
    }
}