
namespace EMA.Disaster.Recovery.Models
{
    public class SBAPhotos
    {
        public int ID { get; set; }
        public int SBAWorksheetID { get; set; }
        public string PhotoUrl { get; set; }

        public virtual SBAWorksheet SBAWorksheet { get; set; }
    }
}