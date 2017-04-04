
namespace EMA.Disaster.Recovery.Models
{
    public class Address
    {
        public int ID { get; set; }
        public int CountyMunicipalityID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public float Longitude { get; set; }
        public float Lattitude { get; set; }
        
        public virtual CountyMunicipality CountyMunicipality { get; set; }
    }
}