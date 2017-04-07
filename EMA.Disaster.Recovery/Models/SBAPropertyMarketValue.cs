
namespace EMA.Disaster.Recovery.Models
{
    public class SBAPropertyMarketValue
    {
        public int ID { get; set; }
        public string PropertySectionStructure { get; set; }
        public string PropertySectionContents { get; set; }
        public string PropertySectionLand { get; set; }
        public int DisasterLossStructures { get; set; }
        public int DisasterLossContents { get; set; }
        public int DisasterLossLand { get; set; }
        public int InsuranceAmountStructures { get; set; }
        public int InsuranceAmountContents { get; set; }
        public int InsuranceAmountLand { get; set; }

        public virtual SBAWorksheet SBAWorksheet { get; set; }
    }
}