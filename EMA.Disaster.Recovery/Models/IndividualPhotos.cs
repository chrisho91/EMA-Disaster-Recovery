
namespace EMA.Disaster.Recovery.Models
{
    public class IndividualPhotos
    {
        public int ID { get; set; }
        public string PhotoUrl { get; set; }

        public virtual IndividualWorksheet IndividualWorksheet { get; set; }
    }
}